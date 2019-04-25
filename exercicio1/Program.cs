using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace gcgcg
{
	class Render : GameWindow
	{
		Mundo mundo = new Mundo();

		float x1 = -300, x2 = 300, y1 = 300, y2 = -300, z1 = -1, z2 = 1;

		public Render(int width, int height) : base(width, height) { }

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			Console.WriteLine("[2] .. OnLoad");
		}
		protected override void OnUpdateFrame(FrameEventArgs e)
		{

			base.OnUpdateFrame(e);
			Console.WriteLine("[3] .. OnUpdateFrame");

			GL.MatrixMode(MatrixMode.Projection);
			GL.LoadIdentity();
			GL.Ortho(x1, x2, y1, y2, z1, z2);
		}

		protected void KeyPress(OpenTK.Input.KeyboardState keyboardState)
		{
			
		}
		protected override void OnRenderFrame(FrameEventArgs e)
		{
			base.OnRenderFrame(e);
			Console.WriteLine("[4] .. OnRenderFrame");

			GL.Clear(ClearBufferMask.ColorBufferBit);
			GL.ClearColor(Color.DimGray);
			GL.MatrixMode(MatrixMode.Modelview);

			mundo.SRU3D();
			mundo.Desenha();

			this.SwapBuffers();
		}
	}

	class Program
	{
	static void Main(string[] args)
	{
	Console.WriteLine("[1] .. Main");

	Render window = new Render(800, 800);
	window.Run();
	window.Run(1.0/60.0);
	}
	}

}
