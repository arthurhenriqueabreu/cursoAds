using System.Drawing.Drawing2D;
using System.Reflection;

public class RoundedButton : Button
{
    public int BorderRadius { get; set; } = 20;

    public RoundedButton()
    {
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        BackColor = Color.FromArgb(224, 224, 224);
        ForeColor = Color.Black;
        ResizeRedraw = true;

        typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance)
            ?.SetValue(this, true, null);
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);

        var rect = ClientRectangle;
        rect.Width -= 1;
        rect.Height -= 1;
        int d = BorderRadius * 2;

        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

        var rect = ClientRectangle;
        rect.Width -= 1;
        rect.Height -= 1;
        int d = BorderRadius * 2;

        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            using (SolidBrush brush = new SolidBrush(BackColor))
            {
                e.Graphics.FillPath(brush, path);
            }
        }

        TextRenderer.DrawText(
            e.Graphics,
            Text,
            Font,
            rect,
            ForeColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }
}
