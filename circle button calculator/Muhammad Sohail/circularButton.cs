using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Muhammad_Sohail
{
    public class circularButton: System.Windows.Forms.Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs pevent)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(gp);
            base.OnPaint(pevent);
        }
    }
}
