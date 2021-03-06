using System.Collections;
using CoreGraphics;

namespace MTExample3_2 {
	public class DataSeries {
		ArrayList pointList;
		LineStyle lineStyle;
		string seriesName = "Default Name";

		public DataSeries ()
		{
			lineStyle = new LineStyle ();
			pointList = new ArrayList ();
		}

		public LineStyle LineStyle {
			get {
				return lineStyle;
			}
			set {
				lineStyle = value;
			}
		}

		public string SeriesName {
			get {
				return seriesName;
			}
			set {
				seriesName = value;
			}
		}

		public ArrayList PointList {
			get {
				return pointList;
			}
			set {
				pointList = value;
			}
		}

		public void AddPoint (CGPoint pt)
		{
			pointList.Add (pt);
		}
	}
}
