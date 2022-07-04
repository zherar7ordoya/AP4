using BE;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class BLL_Rol : ABSTRACTA.IGestor<BE.BE_Rol>
    {
        readonly MPP.MPP_Rol MPP_ROL;
        public BLL_Rol() => MPP_ROL = new MPP.MPP_Rol();

        //              ▂▃▄▅▆▇█▓▒░ IMPLEMENTA INTERFAZ ░▒▓█▇▆▅▄▃▂

        public bool Eliminar(BE_Rol rol)
        {
            return MPP_ROL.Eliminar(rol);
        }


        public bool Guardar(BE_Rol rol)
        {
            return MPP_ROL.Guardar(rol);
        }


        public BE_Rol ListarObjeto(BE_Rol objeto)
        {
            throw new NotImplementedException();
        }


        public List<BE_Rol> ListarTodo()
        {
            return MPP_ROL.ListarTodo();
        }

        // •°*”˜˜”*°•.ƸӜƷ.•°*”˜˜”*°•.ƸӜƷ•°*”˜˜”*°•.ƸӜƷ.•°*”˜˜”*°•.ƸӜƷ•°*”˜˜”*°•

    }
}
