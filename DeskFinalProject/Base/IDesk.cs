using DeskFinalProject.Singleton;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeskFinalProject.Base
{
    public interface IDesk
    {
        decimal Price { get; }
        FrameType MaterialType { get; } 
        DeskShape GetShape { get; }
        void Credenza();
        void Features();
    }
}
