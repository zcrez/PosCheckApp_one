using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Text;
using GMap.NET;
using GMap.NET.WindowsForms;
using System.Drawing;

namespace PosCheckApp.CustomMarkers
{
    [Serializable]
   public class GArrowRoute : GMapRoute, ISerializable
   {
      [NonSerialized]
      public Pen Pen = new Pen(Brushes.White, 3);
      public Pen APen = new Pen(Brushes.Red, 2);

      public override void OnRender(Graphics g)
      {
          if (IsVisible)
          {
              GPoint startpt=LocalPoints[0];
              for (int i = 0; i < LocalPoints.Count; i++)
              {
                  GPoint p2 = LocalPoints[i];

                  if (i == 0)
                  {
                      startpt = p2;
                  }
                  else
                  {
                      g.DrawLine(Pen, new PointF(startpt.X, startpt.Y), new PointF(p2.X, p2.Y));
                      JudgeDrawArrow(g,  (int)startpt.X, (int)startpt.Y, (int)p2.X, (int)p2.Y);
                      startpt = p2;
                  }
              }
          }
      }

      public void JudgeDrawArrow(Graphics canvas, int x1, int y1, int x2, int y2)
      {
          double dis = Math.Sqrt((x2 - x1)*(x2 - x1)+(y2-y1)*(y2-y1));

          if (dis < 20) return;

         x2 = (x1 + x2) / 2;
          y2 = (y1 + y2) / 2;

          double arrow_height = 10; // 箭头高度    
          double arrow_btomline = 7; // 底边的一半    
    
          double arctangent = Math.Atan(arrow_btomline / arrow_height); // 箭头角度    
          double arrow_len = Math.Sqrt(arrow_btomline * arrow_btomline + arrow_height * arrow_height); // 箭头的长度    
          double[] endPoint_1 = rotateVec(x2 - x1, y2 - y1, arctangent, true,
                  arrow_len);
          double[] endPoint_2 = rotateVec(x2 - x1, y2 - y1, -arctangent, true,
                  arrow_len);
          double x_3 = x2 - endPoint_1[0]; // (x_3,y_3)是第一端点    
          double y_3 = y2 - endPoint_1[1];
          double x_4 = x2 - endPoint_2[0]; // (x_4,y_4)是第二端点    
          double y_4 = y2 - endPoint_2[1];



          canvas.DrawLine(APen, new PointF(x2, y2), new PointF((int)x_3, (int)y_3));
          // 画箭头的一半    
       
          // 画箭头的另一半    
          canvas.DrawLine(APen, new PointF(x2, y2), new PointF((int)x_4, (int)y_4));
      }

      public double[] rotateVec(int px, int py, double ang, bool isChlen,double newLen) 
      {    
    
        double[] rotateResult = new double[2];    
        // 矢量旋转函数，参数含义分别是x分量、y分量、旋转角、是否改变长度、新长度    
        double vx = px * Math.Cos(ang) - py * Math.Sin(ang);    
        double vy = px * Math.Sin(ang) + py * Math.Cos(ang);    
        if (isChlen) {    
            double d = Math.Sqrt(vx * vx + vy * vy);    
            vx = vx / d * newLen;    
            vy = vy / d * newLen;    
            rotateResult[0] = vx;    
            rotateResult[1] = vy;    
        }    
        return rotateResult;    
    }

      public PointLatLng GetCenterPoint()
      {
          double lat = 0;
          double lon = 0;
          for(int i=0; i<this.Points.Count;i++)
          {
              lat += this.Points[i].Lat;
              lon += this.Points[i].Lng;
          }

          return new PointLatLng(lat / this.Points.Count, lon / this.Points.Count);
      }

       static GArrowRoute()
        {

            DefaultStroke.Width = 5;
        }

         public GArrowRoute(string name)
            : base(name)
        {

        }

         public GArrowRoute(IEnumerable<PointLatLng> points, string name)
            : base(points, name)
        {

        }

    
    }
}
