using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MinhaSaude.Data.Banco;

public class DAL<T> where T : class
{
    private readonly MinhaSaudeContext context;

    public DAL(MinhaSaudeContext context)
    {
        this.context = context;
    }

    public IEnumerable<T> Listar
        (
        Expression<Func<T, bool>>? filtro = null,
        Func<IQueryable<T>, IOrderedQueryable<T>>? ordem = null,
        params Expression<Func<T, object>>[] includes
        )
    {
        IQueryable<T> query = context.Set<T>();
        if (filtro != null) query = query.Where(filtro);
        if (ordem != null) query = ordem(query);
        foreach (var include in includes) query = query.Include(include);

        return query.ToList();
    }

    public void Adicionar(T objeto)
    {
        context.Set<T>().Add(objeto);
        context.SaveChanges();
    }

    public void Atualizar(T objeto)
    {
        context.Set<T>().Update(objeto);
        context.SaveChanges();
    }

    public void Deletar(T objeto)
    {
        context.Set<T>().Remove(objeto);
        context.SaveChanges();
    }

    public T? RecuperarPor(Func<T, bool> condicao)
    {
        return context.Set<T>().FirstOrDefault(condicao);
    }
}
