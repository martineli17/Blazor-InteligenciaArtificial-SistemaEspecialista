﻿using Crosscuting.Notificacao;
using Dominio.Interfaces.Repositorio;
using Repositorio.Contexto;
using System;
using System.Threading.Tasks;

namespace Repositorio.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;
        private readonly INotificador _notificador;
        public UnitOfWork(Context context, INotificador notificador)
        {
            _context = context;
            _notificador = notificador;
        }
        public async Task<bool> CommitAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                _notificador.Add("Ocorreu um erro ao processar a operação.", EnumTipoMensagem.Erro);
                return false;
            }
        }
    }
}
