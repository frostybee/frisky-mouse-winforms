using Bee.GlobalHooks;
using MultiDeviceInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bee.MouseHighlighter.UI
{
    public partial class MainForm : Form
    {
        public InputDevice InputDevice;
        private LayeredForm mHighlightForm;
        private LayeredForm mClickHighlightForm;
        private readonly System.Windows.Forms.Timer mTimerClickDisplay = new System.Windows.Forms.Timer();
        private static Bitmap mBitmap_Mouse;
        private static Bitmap mBitmap_Click;
        private bool ClickEnable = true;
        private int ClickSize = 20;
        private byte ClickOpacity = 50;
        private Color ClickColor = Color.Red;
        private int ClickDisplay = 800;
        private int HighlightSize = 20;
        private Color HighlightColor = Color.Yellow;
        private byte HighlightOpacity = 50;

        public class MouseData
        {
            public int PosX;
            public int PosY;
            public InputDevice.DeviceData Data;
        }
        public Dictionary<IntPtr, MouseData> Mouses = new Dictionary<IntPtr, MouseData>();
        private readonly System.Windows.Forms.Timer bringToFrontTimer = new System.Windows.Forms.Timer();
        
        public MainForm()
        {
            InitializeComponent();
            mHighlightForm = new HighlightForm(this);
            mClickHighlightForm = new LeftClickForm(this);
            base.Load += MainForm_Load;
            base.FormClosing += MainForm_FormClosing;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            if (bringToFrontTimer != null)
            {
                bringToFrontTimer.Stop();
                bringToFrontTimer.Tick -= BringToFrontTimer_Tick;
                bringToFrontTimer.Dispose();

            }
            if (mTimerClickDisplay != null)
            {
                mTimerClickDisplay.Stop();
                mTimerClickDisplay.Tick -= TimerTrackbar_Update;
                mTimerClickDisplay.Dispose();              
            }
            mHighlightForm.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            InitMouseSettings();
            SetHighlight();
            mHighlightForm.Show();
        }
      /*  private void GlobalMouseHook_OnMouseMove(object sender, GlobalMouseEventArgs e)
        {
            Console.WriteLine("--- Testing ---");
            string pointerStatus = "Pointer Position: (" + e.PointerPos.X.ToString() + "," + e.PointerPos.Y.ToString() + ")"; //Let's not do StringBuilder for this one.
            string windowStatus = "Window Position: (" + MousePosition.X.ToString() + "," + MousePosition.Y.ToString() + ")"; //Let's not do StringBuilder for this one.
            Console.WriteLine(pointerStatus);
            Console.WriteLine(windowStatus);
            try
            {
                //mHighlightForm.Left = e.PointerPos.X + mBitmap_Mouse.Width / 2;
                //mHighlightForm.Top = e.PointerPos.Y - mBitmap_Mouse.Height / 2;
                mHighlightForm.Left = MousePosition.X - mBitmap_Mouse.Width / 2;
                mHighlightForm.Top = MousePosition.Y - mBitmap_Mouse.Height / 2;
            }
            catch (Exception ex)
            {
            }
        }*/

        private void SetHighlight()
        {
            // TODO: move this to a helper or their respective class. 
            try
            {
                mBitmap_Mouse = new Bitmap(this.HighlightSize * 2, this.HighlightSize * 2);
                Graphics.FromImage((Image)mBitmap_Mouse).FillEllipse((Brush)new SolidBrush(HighlightColor), 0, 0, this.HighlightSize * 2, this.HighlightSize * 2);
                this.mHighlightForm.SetBitmap(mBitmap_Mouse, this.HighlightOpacity);
                mBitmap_Click = new Bitmap(this.ClickSize * 2, this.ClickSize * 2);
                //Graphics.FromImage((Image)mBitmap_Click).FillEllipse((Brush)new SolidBrush(this.ClickColor), 0, 0, this.ClickSize * 2, this.ClickSize * 2);
                //mClickHighlightForm.SetBitmap(Form1.mBitmap_Click, this.ClickOpacity);

                mBitmap_Click = new Bitmap(this.ClickSize * 2, this.ClickSize * 2);
                Graphics.FromImage((Image)mBitmap_Click).FillEllipse((Brush)new SolidBrush(this.ClickColor), 0, 0, this.ClickSize * 2, this.ClickSize * 2);
                this.mClickHighlightForm.SetBitmap(mBitmap_Click, this.ClickOpacity);
            }
            catch (Exception ex)
            {
            }
        }
        private void InitMouseSettings()
        {
            // Multi mouse input initd
            InputDevice = new MultiDeviceInput.InputDevice(Handle);
            InputDevice.EnumerateDevices();
            InputDevice.MouseDown += new MultiDeviceInput.InputDevice.MouseEventHandler(_MouseDown);
            InputDevice.MouseMove += new MultiDeviceInput.InputDevice.MouseEventHandler(_MouseMove);
            InputDevice.MouseUp += new MultiDeviceInput.InputDevice.MouseEventHandler(_MouseUp);
            InputDevice.MouseWheel += new MultiDeviceInput.InputDevice.MouseEventHandler(_MouseWheel);
            // Time interval for bringing the layered window to front.
            bringToFrontTimer.Interval = 1000;
            bringToFrontTimer.Tick += BringToFrontTimer_Tick;
            this.mTimerClickDisplay.Interval = this.ClickDisplay;
            this.mTimerClickDisplay.Tick += TimerTrackbar_Update;
            this.mTimerClickDisplay.Stop();
        }
        private void TimerTrackbar_Update(object sender, EventArgs e)
        {
            try
            {
                this.mClickHighlightForm.Hide();
            }
            catch (Exception ex)
            {
            }
        }
        private void BringToFrontTimer_Tick(object sender, EventArgs e)
        {
            //Call method
            //   mHighlightForm.BringToFront();
        }
        private void _MouseMove(object sender, InputDevice.MouseControlEventArgs e)
        {
            //TODO: not moving well when selecting text. Need to track when the mouse is down and moving so that the form should be hidden.
            //Console.WriteLine($"Mouse moved! {e.RightButton} {e.DeviceData.MouseY} {e.DeviceData.MouseX}");


            //Console.WriteLine("--- Testing ---");
            string pointerStatus = "Pointer Position: (" + e.DeviceData.MouseX.ToString() + "," + e.DeviceData.MouseY.ToString() + ")"; //Let's not do StringBuilder for this one.
            string windowStatus = "Window Position: (" + MousePosition.X.ToString() + "," + MousePosition.Y.ToString() + ")"; //Let's not do StringBuilder for this one.
            Console.WriteLine(pointerStatus);
            Console.WriteLine(windowStatus);
            try
            {
                //mHighlightForm.Left = e.PointerPos.X + mBitmap_Mouse.Width / 2;
                //mHighlightForm.Top = e.PointerPos.Y - mBitmap_Mouse.Height / 2;
                mHighlightForm.Left = MousePosition.X - mBitmap_Mouse.Width / 2;
                mHighlightForm.Top = MousePosition.Y - mBitmap_Mouse.Height / 2;


                //mHighlightForm.Focus();
            }
            catch (Exception ex)
            {
            }

            //if (Focused) 
            ///Cursor.Position = new System.Drawing.Point(Location.X + Width / 2, Location.Y + Height / 2);

            /*    if (Mouses.ContainsKey(e.DeviceData.Info.deviceHandle))
                {
                    // convert to absolute mouse cooridnates
                    MouseData Current = Mouses[e.DeviceData.Info.deviceHandle];
                    Current.PosX += e.DeltaX;
                    Current.PosY += e.DeltaY;

                    if (Current.PosX < 0) Current.PosX = 0;
                    if (Current.PosY < 0) Current.PosY = 0;
                    //if (Current.PosX >= Canvas.Width) Current.PosX = Canvas.Width - 1;
                    //if (Current.PosY >= Canvas.Height) Current.PosY = Canvas.Height - 1;
                }*/
        }
        private void _MouseDown(object sender, InputDevice.MouseControlEventArgs e)
        {
            try
            {
                if (!this.ClickEnable)
                    return;
                this.mClickHighlightForm.Left = MousePosition.X- mBitmap_Click.Width / 2;
                this.mClickHighlightForm.Top = MousePosition.Y - mBitmap_Click.Height / 2;
                this.mClickHighlightForm.Show();
                this.mTimerClickDisplay.Stop();
                this.mTimerClickDisplay.Start();
            }
            catch (Exception ex)
            {
            }
            return;

            /*
                        if (e.LeftButton)
                        {

                            Console.WriteLine($"Mouse down! {e.RightButton} {e.DeltaX} {e.DeltaY}");
                            //MouseEventButtonDownLeft(this, Mouses[e.DeviceData.Info.deviceHandle]);
                        }
                        else if (e.RightButton)
                        {
                            //MouseEventButtonDownRight(this, Mouses[e.DeviceData.Info.deviceHandle]);
                        }*/
        }
        private void _MouseUp(object sender, InputDevice.MouseControlEventArgs e)
        {
            //TODO: Hmmm ok! After detecting a click or right-click, use a timmer to bring the layered window to front!
            // 1) Another option is to use to capture https://docs.microsoft.com/en-us/windows/win32/menurc/wm-contextmenu message.
            // 2) Profile the bring to front option on mouse move?
            // This solution seems to be working!
            bringToFrontTimer.Start();
            //  We wanna make sure the layered window is always set as top most after opening a system or application's context menu.
            //mHighlightForm.BringToFront();
            if (!Mouses.ContainsKey(e.DeviceData.Info.deviceHandle))
            {
                MouseData NewMouse = new MouseData();
                //NewMouse.PosX = Canvas.Width / 2;
                //NewMouse.PosY = Canvas.Height / 2;
                NewMouse.Data = e.DeviceData;
                Mouses.Add(e.DeviceData.Info.deviceHandle, NewMouse);
            }

            if (Mouses.ContainsKey(e.DeviceData.Info.deviceHandle) && e.LeftButton)
            {
                //MouseEventButtonUpLeft(this, Mouses[e.DeviceData.Info.deviceHandle]);
            }
            else if (e.RightButton)
            {
                //MouseEventButtonUpRight(this, Mouses[e.DeviceData.Info.deviceHandle]);
            }
        }

        private void _MouseWheel(object sender, InputDevice.MouseControlEventArgs e)
        {
            if (Mouses.ContainsKey(e.DeviceData.Info.deviceHandle))
            {
                if (e.Wheel > 0)
                {
                    //MouseEventWheelUp(this, Mouses[e.DeviceData.Info.deviceHandle]);
                }
                else if (e.Wheel < 0)
                {
                    //MouseEventWheelDown(this, Mouses[e.DeviceData.Info.deviceHandle]);
                }

            }
        }

     
        protected override void WndProc(ref Message m)
        {
            if (InputDevice != null)
                InputDevice.ProcessMessage(m);
            if (m.Msg == InputDevice.WM_CONTEXTMENU)
            {
                Console.WriteLine("System context menu?..." + m.Msg);
            }
            if (m.Msg == InputDevice.WM_COMMAND)
            {
                Console.WriteLine("System context menu WM_COMMAND?..." + m.Msg);
            }
            if (m.Msg == InputDevice.WM_ENTERMENULOOP)
            {
                Console.WriteLine("System context menu WM_COMMAND?..." + m.Msg);
            }

            base.WndProc(ref m);
        }

    }
}
