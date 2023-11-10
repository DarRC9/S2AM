using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

class RoundButton : Button
{
    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);

        GraphicsPath path = new GraphicsPath();
        int radius = 20; // Adjust the radius to control the roundness of the corners

        // Top-left corner
        path.AddArc(new Rectangle(0, 0, 2 * radius, 2 * radius), 180, 90);

        // Top-right corner
        path.AddArc(new Rectangle(Width - 2 * radius, 0, 2 * radius, 2 * radius), 270, 90);

        // Bottom-right corner
        path.AddArc(new Rectangle(Width - 2 * radius, Height - 2 * radius, 2 * radius, 2 * radius), 0, 90);

        // Bottom-left corner
        path.AddArc(new Rectangle(0, Height - 2 * radius, 2 * radius, 2 * radius), 90, 90);

        this.Region = new Region(path);
    }
}