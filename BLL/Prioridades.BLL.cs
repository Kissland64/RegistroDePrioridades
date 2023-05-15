using Registrodeprioridades.DAL;
using Registrodeprioridades.Modelo;

public class PrioridadesBLL
{
    private PrioridadesContext _context;

    public PrioridadesBLL(PrioridadesContext context)
    {
        _context = context;
    }

    public bool Existe(int PrioridadesId)
    {
        return _context.Prioridades.Any(p => p.PrioridadesId == PrioridadesId);
    }

    public bool Insertar(Prioridades prioridades)
    {
        _context.Prioridades.Add(prioridades);
        int guardo = _context.SaveChanges();
        _context.Entry(prioridades).State = EntityState.Detached;
        return guardo > 0; 
    }

    public bool Modificar(Prioridades prioridades)
    {
        _context.Update(prioridades);
        int modifico = _context.SaveChanges();
        _context.Entry(prioridades).State = EntityState.Detached;
        return modifico > 0;       
    }

    public bool guardar(Prioridades prioridades)
    {
        if(!Existe(prioridades.PrioridadesId))
        {
            return Insertar(prioridades);
        }
        else
        {
            return Modificar(prioridades);
        }
    }

    public bool Eliminar(Prioridades prioridad)
    {
        _context.Prioridades.Remove(prioridad);
        int elimino = _context.SaveChanges();
        _context.Entry(prioridad).State = EntityState.Detached;

        return elimino > 0;
        
    }

    public Prioridades? Buscar(int prioridadesId)
    {
        return _context.Prioridades
        .AsNoTracking()
        .SingleOrDefault(p => p.PrioridadesId == prioridadesId);
    }


    public List<Prioridades> ObtenerLista()
    {
        return _context.Prioridades
        .AsNoTracking()
        .ToList();
    }
}