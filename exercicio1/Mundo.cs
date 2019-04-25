using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace gcgcg
{
  class Mundo
  {
    private Ponto4D ptoDirCim = new Ponto4D(100, 100);
    private Ponto4D ptoOrigem = new Ponto4D(0,0);

    private Matematica mat = new Matematica();

    public void Desenha()
    {
      Ponto4D pto = new Ponto4D(0,0);
      Console.WriteLine("[6] .. Desenha");
      
      GL.LineWidth(5);
      GL.PointSize(5);
      GL.Color3(Color.Yellow);

      GL.Begin(PrimitiveType.Points);
        int loop = 0;
        while (loop < 360)
        {
          pto = mat.ptoCirculo(loop, 100);
          GL.Vertex2(pto.X, pto.Y);
          loop += 5;
        }
        loop = 0;
      GL.End();
    }

    public void SRU3D()
    {
Console.WriteLine("[5] .. SRU3D");

      GL.LineWidth(1);
      GL.Begin(PrimitiveType.Lines);
      GL.Color3(Color.Red);
      GL.Vertex3(0, 0, 0); GL.Vertex3(200, 0, 0);
      GL.Color3(Color.Green);
      GL.Vertex3(0, 0, 0); GL.Vertex3(0, -200, 0);
      GL.Color3(Color.Blue);
      GL.Vertex3(0, 0, 0); GL.Vertex3(0, 0, 200);
      GL.End();
    }
  }

}