﻿//-----------------------------------------------------------------------
// <copyright file="FormRegionSelectWithMouse.cs" company="Gavin Kendall">
//     Copyright (c) 2008-2022 Gavin Kendall
// </copyright>
// <author>Gavin Kendall</author>
// <summary>A form that covers all the available screens so we can do a mouse-driven region select.</summary>
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <https://www.gnu.org/licenses/>.
//-----------------------------------------------------------------------
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace AutoScreenCapture
{
    /// <summary>
    /// A form that covers all the available screens so we can do a mouse-driven region select.
    /// </summary>
    public partial class FormRegionSelectWithMouse : Form
    {
        private bool _sendToClipboard;

        private Bitmap _bitmapSource;
        private Bitmap _bitmapDestination;

        private int _selectX;
        private int _selectY;
        private int _selectWidth;
        private int _selectHeight;
        private Pen _selectPen;

        /// <summary>
        /// X output
        /// </summary>
        public int outputX;

        /// <summary>
        /// Y output
        /// </summary>
        public int outputY;

        /// <summary>
        /// Width output
        /// </summary>
        public int outputWidth;

        /// <summary>
        /// Height output
        /// </summary>
        public int outputHeight;

        /// <summary>
        /// Empty constructor.
        /// </summary>
        public FormRegionSelectWithMouse()
        {
            InitializeComponent();

            outputX = 0;
            outputY = 0;
            outputWidth = 0;
            outputHeight = 0;
        }

        /// <summary>
        /// An event handler for handling when the mouse selection has completed for the mouse-driven region capture.
        /// </summary>
        public event EventHandler MouseSelectionCompleted;

        /// <summary>
        /// Invokes the mouse selection completed event handler.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteMouseSelection(object sender, EventArgs e)
        {
            MouseSelectionCompleted?.Invoke(sender, e);
        }

        /// <summary>
        /// Loads the canvas with the chosen output mode.
        /// </summary>
        /// <param name="sendToClipboard">Determines if we want to send the captured image to the clipboard.</param>
        public void LoadCanvas(bool sendToClipboard)
        {
            _sendToClipboard = sendToClipboard;

            Rectangle canvas = SystemInformation.VirtualScreen;

            WindowState = FormWindowState.Normal;

            Top = canvas.X;
            Left = canvas.Y;
            Width = canvas.Width;
            Height = canvas.Height;

            WindowState = FormWindowState.Normal;

            Hide();

            _bitmapSource = new Bitmap(Width, Height);

            using (Graphics graphics = Graphics.FromImage(_bitmapSource))
            {
                graphics.CopyFromScreen(0, 0, 0, 0, _bitmapSource.Size, CopyPixelOperation.SourceCopy);

                using (MemoryStream s = new MemoryStream())
                {
                    _bitmapSource.Save(s, System.Drawing.Imaging.ImageFormat.Bmp);

                    pictureBoxMouseCanvas.Size = new Size(Width, Height);
                    pictureBoxMouseCanvas.Image = Image.FromStream(s);
                }
            }

            _bitmapSource.Dispose();

            Show();

            Cursor = Cursors.Cross;
        }

        /// <summary>
        /// Handles what happens when the user is moving the mouse pointer on the screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxMouseCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBoxMouseCanvas.Image == null || _selectPen == null) return;

            pictureBoxMouseCanvas.Refresh();

            _selectWidth = e.X - _selectX;
            _selectHeight = e.Y - _selectY;

            pictureBoxMouseCanvas.CreateGraphics().DrawRectangle(_selectPen, _selectX, _selectY, _selectWidth, _selectHeight);
        }

        /// <summary>
        /// Handles what happens when the user has the mouse button held down while dragging the mouse selection on the screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxMouseCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _selectX = e.X;
                _selectY = e.Y;

                _selectPen = new Pen(Color.Red, 2)
                {
                    DashStyle = DashStyle.Dash
                };
            }

            pictureBoxMouseCanvas.Refresh();
        }

        /// <summary>
        /// Selects a bitmap image that represents a selected area of the screen and calls the CompleteMouseSelection event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxMouseCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (pictureBoxMouseCanvas.Image == null || _selectPen == null) return;

            if (e.Button == MouseButtons.Left)
            {
                pictureBoxMouseCanvas.Refresh();

                _selectWidth = e.X - _selectX;
                _selectHeight = e.Y - _selectY;

                pictureBoxMouseCanvas.CreateGraphics().DrawRectangle(_selectPen, _selectX, _selectY, _selectWidth, _selectHeight);
            }

            Bitmap bitmap = SelectBitmap();

            if (bitmap != null)
            {
                if (_sendToClipboard)
                {
                    SendToClipboard(bitmap);
                }

                bitmap.Dispose();

                outputX = _selectX;
                outputY = _selectY;
                outputWidth = _selectWidth;
                outputHeight = _selectHeight;

                CompleteMouseSelection(sender, e);
            }

            Cursor = Cursors.Arrow;

            Close();
        }

        /// <summary>
        /// Gets a bitmap image from an area of the screen based on X, Y, Width, and Height.
        /// </summary>
        /// <returns>Returns a bitmap image based on X, Y, Width, and Height.</returns>
        private Bitmap SelectBitmap()
        {
            if (_selectWidth > 0)
            {
                Rectangle rect = new Rectangle(_selectX, _selectY, _selectWidth, _selectHeight);
                _bitmapDestination = new Bitmap(pictureBoxMouseCanvas.Image, pictureBoxMouseCanvas.Width, pictureBoxMouseCanvas.Height);

                _bitmapSource = new Bitmap(_selectWidth, _selectHeight);

                using (Graphics g = Graphics.FromImage(_bitmapSource))
                {
                    g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    g.CompositingQuality = CompositingQuality.HighQuality;
                    g.DrawImage(_bitmapDestination, 0, 0, rect, GraphicsUnit.Pixel);
                }

                return _bitmapSource;
            }

            return null;
        }

        /// <summary>
        /// Sends the provided bitmap image to the clipboard.
        /// </summary>
        /// <param name="bitmap">A bitmap image to send to the clipboard.</param>
        private void SendToClipboard(Bitmap bitmap)
        {
            if (bitmap != null)
            {
                Clipboard.SetImage(bitmap);
            }
        }
    }
}
