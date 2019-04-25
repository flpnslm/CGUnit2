using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace exercicio2
{
  class Render : GameWindow
  {
    Mundo mundo = new Mundo();
    Camera camera = new Camera(-300, 300, 300, -300, -1, 1);
    
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
      GL.Ortho(this.camera.X1, this.camera.X2, this.camera.Y1, this.camera.Y2, this.camera.Z1, this.camera.Z2);
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

    protected override void OnKeyPress(KeyPressEventArgs e)
    {
      switch (e.KeyChar.ToString().ToLower())
      {
          case "d":
            this.camera.X1 -= 3;
            this.camera.X2 -= 3;
            break;
          case "e":
            this.camera.X1 += 3;
            this.camera.X2 += 3;
            break;
          case "c":
            this.camera.Y1 += 3;
            this.camera.Y2 += 3;
            break;
          case "b":
            this.camera.Y1 -= 3;
            this.camera.Y2 -= 3;
            break;
          case "i":
            this.camera.X1 += 3;
            this.camera.X2 -= 3;
            this.camera.Y1 -= 3;
            this.camera.Y2 += 3;
            break;
          case "o":
            this.camera.X1 -= 3;
            this.camera.X2 += 3;
            this.camera.Y1 += 3;
            this.camera.Y2 -= 3;
            break;
      }
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
