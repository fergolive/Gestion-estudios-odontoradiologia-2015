﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
namespace Persistencia
{
    public interface IPersistenciaOxi
    {
        OptParaImplante BuscarOptParaImplante(String factura);
        OptParaImplante BuscarOptParaImplantePorId(int id);
        void AgregarOptParaImplante(OptParaImplante oxi);
        void ModificarOptParaImplante(OptParaImplante oxi);
        void EliminarOptParaImplante(OptParaImplante oxi);
        List<OptParaImplante> ListarOxisPendientes();
    }
}
