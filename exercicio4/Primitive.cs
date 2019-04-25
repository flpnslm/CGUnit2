using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace exercicio4
{


    static class Primitive
    {
    private static PrimitiveType[] pType = new PrimitiveType[10]
    {
        PrimitiveType.Points,
        PrimitiveType.Lines,
        PrimitiveType.LineLoop,
        PrimitiveType.LineStrip,
        PrimitiveType.Triangles,
        PrimitiveType.TriangleStrip,
        PrimitiveType.TriangleFan,
        PrimitiveType.Quads,
        PrimitiveType.QuadStrip,
        PrimitiveType.Polygon,
    };

    public static PrimitiveType CurrentPrimitive = pType[0];
    private static int index = 0;
    private static PrimitiveType primitive = new PrimitiveType();
        public static void NewPrimitive()
        {
            index = index == 9 ? 0 : index+1;
            
            CurrentPrimitive = pType[index];
        }

        

    }
}