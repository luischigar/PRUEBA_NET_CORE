using api_prueba_net_core.DBContext;
using api_prueba_net_core.Interfaces;
using api_prueba_net_core.Models.Entidad;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_prueba_net_core.Catalogos
{
    public class catalogoPersona : IPersona
    {
        private readonly prueba_net_coreContext context;
        public catalogoPersona(prueba_net_coreContext _context)
        {
            context = _context;
        }
        public async Task<IEnumerable<Persona>> getPersonas()
        {

            return await context.Personas.ToListAsync();
        }
        public async Task<Persona> getPersonasPorUsuario(string usuario)
        {
            //return await context.Personas.Include(f=>f.tipo_Persona).Where(e=>e.Usuario == usuario).FirstOrDefaultAsync();
            return await context.Personas.Where(e => e.Usuario == usuario).FirstOrDefaultAsync();
        }

        public async Task<Persona> postPersonas(Persona persona)
        {
            Persona oPersona = new Persona();
            await context.Personas.AddAsync(persona);
            await context.SaveChangesAsync();
            return oPersona;
        }

        public async Task<Persona> putPersonas(Persona persona)
        {
            Persona oPersona = new Persona();

            context.Entry(persona).State = EntityState.Modified;
            await context.SaveChangesAsync();

            oPersona = await context.Personas.Where(e => e.IdPersona == persona.IdPersona).FirstOrDefaultAsync();
            return oPersona;
        }
        public async Task<Persona> deletePersonas(int idPersona)
        {
            Persona oPersona = new Persona();
            oPersona = await context.Personas.Where(e => e.IdPersona == idPersona).FirstOrDefaultAsync();

            context.Entry(oPersona).State = EntityState.Deleted;
            await context.SaveChangesAsync();

            return oPersona;
        }
    }
}
