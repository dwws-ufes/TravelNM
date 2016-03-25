﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Model;

namespace Application
{
    public class ManutencaoEstado
    {
        TravelMNContext db = new TravelMNContext();

        public List<Estado> ObterEstados()
        {
            var estados = db.Estado.ToList();
            return estados;
        }

        public List<Estado> ObterEstadoId(int id)
        {
            var estados = db.Estado.Where(e => e.Codigo == id).ToList();
            return estados;
        }
    }
}