using CapaEntidad;

namespace CapaDatos
{
    public class TipoMedicamentoDAL
    {
        public List<TipoMedicamentoCLS> ListartipoMedicamento()
        {
            List<TipoMedicamentoCLS> lista = new List<TipoMedicamentoCLS>();
            lista.Add(new TipoMedicamentoCLS
            {
                idTipoMedicamento = 1,
                nombre = "Pastillas",
                descripcion = "Medicamento en forma de pastillas"
            });
            lista.Add(new TipoMedicamentoCLS
            {
                idTipoMedicamento = 2,
                nombre = "Jarabe",
                descripcion = "Medicamento en forma de jarabe"
            });

            return lista;
        }
    }
}