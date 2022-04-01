using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace _7_oop
{
    class Command
    {
        public virtual void execute(PPoint selection) { }
        public virtual void unexecute() { }
        public virtual Command clone() { return new Command(); }
    }

	class MoveHorizontalCommand : Command
	{
		PPoint _selection;
		int _dx;
		public MoveHorizontalCommand(int dx)
		{
			_dx = dx;
			_selection = null;
		}
		public override void execute(PPoint selection)
		{
			_selection = selection;
			_selection.HorizontalMove(_dx);
		}
		public override void unexecute()
		{
			_selection.HorizontalMove(-_dx);
		}
		public override Command clone()
		{
			return new MoveHorizontalCommand(_dx);
		}
	}
	class MoveVerticalCommand : Command
	{
		PPoint _selection;
		int _dy;
		public MoveVerticalCommand(int dy)
		{
			_dy = dy;
			_selection = null;
		}
		public override void execute(PPoint selection)
		{
			_selection = selection;
			_selection.VerticalMove(_dy);
		}
		public override void unexecute()
		{
			_selection.VerticalMove(-_dy);
		}
		public override Command clone()
		{
			return new MoveVerticalCommand(_dy);
		}
	}
	class ResizeCommand: Command
    {
		PPoint _selection;
		int _radius;
		public ResizeCommand(int radius)
		{
			_radius = radius;
			_selection = null;
		}
		public override void execute(PPoint selection)
		{
			_selection = selection;
			_selection.Resize(_radius);
		}
		public override void unexecute()
		{
			_selection.Resize(-_radius);
		}
		public override Command clone()
		{
			return new ResizeCommand(_radius);
		}
	}
	/*class ColorChangeCommand: Command
	{
		PPoint _selection;
		Color _color;
		public ColorChangeCommand(Color color)
		{
			_color = color;
			_selection = null;
		}
		public override void execute(PPoint selection)
		{
			_selection = selection;
			_selection.ColorChange(_color);
		}
		public override void unexecute()
		{
			_selection.ColorChange(Color.White);
		}
		public override Command clone()
		{
			return new ColorChangeCommand(_color);
		}
	}
	*/
}
