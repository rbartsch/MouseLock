// TODO:
// - Ability to enter custom constraint value
// - Ability to apply  optional fix for offset if affected

using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;

namespace MouseLock {
    public partial class Form1 : Form {
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        IKeyboardMouseEvents globalHook;
        bool activated = false;
        Rectangle constrainedArea;
        bool customConstraint = false;
        bool endCustomConstraintModifier = false;

        public void SubscribeAll() {
            globalHook = Hook.GlobalEvents();
            globalHook.MouseMoveExt += GlobalHookMouseMove;
            globalHook.KeyPress += GlobalDeactivateKeyPress;
            globalHook.KeyDown += GlobalDeactivateModifier;
        }

        public void UnsubscribeAll() {
            globalHook.MouseMoveExt -= GlobalHookMouseMove;
            globalHook.KeyPress -= GlobalDeactivateKeyPress;
            globalHook.KeyDown -= GlobalDeactivateModifier;
            globalHook.Dispose();
        }

        private void GlobalDeactivateModifier(object sender, KeyEventArgs e) {
            if (e.Alt == true && e.Shift == true) {
                endCustomConstraintModifier = true;
            }
            else {
                endCustomConstraintModifier = false;
            }
        }

        private void GlobalDeactivateKeyPress(object sender, KeyPressEventArgs e) {
            //Console.WriteLine( "KeyPress: \t{0}", e.KeyChar );

            if (endCustomConstraintModifier) {
                if (e.KeyChar == '2' || e.KeyChar == '@') {
                    if (customConstraint) {
                        custConstraintBtn.PerformClick();
                    }
                    activationBtn.PerformClick();
                }
            }
        }

        private void GlobalHookMouseMove(object sender, MouseEventExtArgs e) {
            //Console.WriteLine( "Mouse Pos: \t{0}", e.Location );

            // horizontal
            if (horizontalCheckBox.Checked) {
                if (e.Location.X <= constrainedArea.Location.X) {
                    e.Handled = true;
                    SetCursorPos(constrainedArea.Location.X, e.Location.Y);
                }
                else if (e.Location.X >= constrainedArea.Location.X + constrainedArea.Size.Width) {
                    e.Handled = true;
                    SetCursorPos(constrainedArea.Location.X + constrainedArea.Size.Width, e.Location.Y);
                }
            }

            // vertical
            if (verticalCheckBox.Checked) {
                if (e.Location.Y <= constrainedArea.Location.Y) {
                    e.Handled = true;
                    SetCursorPos(e.Location.X, constrainedArea.Location.Y);
                }
                else if (e.Location.Y >= constrainedArea.Location.Y + constrainedArea.Size.Height) {
                    e.Handled = true;
                    SetCursorPos(e.Location.X, constrainedArea.Location.Y + constrainedArea.Size.Height);
                }
            }
        }

        private void SetDefaultConstraint() {
            constrainedArea = new Rectangle(0, 0, SystemInformation.PrimaryMonitorSize.Width - 1, SystemInformation.PrimaryMonitorSize.Height - 1);
            constraintTypeSetLbl.ForeColor = Color.Green;
            constraintTypeSetLbl.Text = "default (resolution size) constraint set!";
        }

        // Custom constraint is based on form screen size coordinates
        private void SetCustomConstraint() {
            Point location = ActiveForm.PointToScreen(Point.Empty);
            Size customSize = new Size(ActiveForm.Size.Width - 16, ActiveForm.Size.Height - 36); // apply - 16 to width and -36 to height for hacky(?) offset fix
            Console.WriteLine("Custom location: {0}", location);
            Console.WriteLine("Custom size: {0}", customSize);
            constrainedArea = new Rectangle(location, customSize);
            constraintTypeSetLbl.ForeColor = Color.Green;
            constraintTypeSetLbl.Text = "custom (according to form size) constraint set!";
        }

        private void ActivationBtn_Click(object sender, EventArgs e) {
            activated = !activated;

            if (activated) {
                activationBtn.Text = "Deactivate";
                SubscribeAll();
                WindowState = FormWindowState.Minimized;
            }
            else {
                activationBtn.Text = "Activate";
                UnsubscribeAll();
                WindowState = FormWindowState.Normal;
            }
        }

        private void CustConstraintBtn_Click(object sender, EventArgs e) {
            customConstraint = !customConstraint;

            if (customConstraint) {
                custConstraintBtn.Text = "Default constraint";
                //ActiveForm.Opacity = 0.5;
                SetCustomConstraint();
            }
            else {
                custConstraintBtn.Text = "Custom constraint";
                //ActiveForm.Opacity = 1.0;
                SetDefaultConstraint();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(e.Link.LinkData.ToString());
        }

        private void Form1_Load(object sender, EventArgs e) {
            LinkLabel.Link link = new LinkLabel.Link {
                LinkData = "https://github.com/rbartsch/MouseLock/"
            };
            linkLabel1.Links.Add(link);

            SetDefaultConstraint();
        }

        public Form1() {
            InitializeComponent();
        }
    }
}