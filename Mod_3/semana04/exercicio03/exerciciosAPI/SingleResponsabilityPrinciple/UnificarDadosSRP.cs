using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exerciciosAPI.Models;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace exerciciosAPI.SingleResponsabilityPrinciple
{
    public class UnificarDadosSRP
    {
        private readonly List<DetalheModel> _listaDetalhesModel;
        public double MediaNotas {get; set; }
        public string FeedBack {get; set; }

        public UnificarDadosSRP(List<DetalheModel> listaDetalhesModel)
        {
            this._listaDetalhesModel = listaDetalhesModel;        
        }

        private void CalcularMedia()
        {
            MediaNotas = this._listaDetalhesModel.Select(item => item.Nota.GetHashCode())
                                                    .Average();
        }

        private void ConcatenarFeedBack()
        {
            var feedbacksList = this._listaDetalhesModel.Select(item => item.FeedBack)
                                                    .ToList();

            FeedBack = string.Join(" ", feedbacksList);
        }

        public void Resultado()
        {
            CalcularMedia();
            ConcatenarFeedBack();
        }

    }
}