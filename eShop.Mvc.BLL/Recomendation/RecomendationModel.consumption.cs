﻿// This file was auto-generated by ML.NET Model Builder. 
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace EShop_Mvc_BLL
{
    public partial class RecomendationModel
    {
        /// <summary>
        /// model input class for RecomendationModel.
        /// </summary>
        #region model input class
        public class ModelInput
        {
            [ColumnName(@"userId")]
            public float UserId { get; set; }

            [ColumnName(@"gameId")]
            public float GameId { get; set; }

            [ColumnName(@"rating")]
            public float Rating { get; set; }

            [ColumnName(@"genreId")]
            public string GenreId { get; set; }

        }

        #endregion

        /// <summary>
        /// model output class for RecomendationModel.
        /// </summary>
        #region model output class
        public class ModelOutput
        {
            public float Score { get; set; }
        }
        #endregion

        private static string MLNetModelPath = Path.GetFullPath("RecomendationModel.zip");

        public static readonly Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(() => CreatePredictEngine(), true);

        /// <summary>
        /// Use this method to predict on <see cref="ModelInput"/>.
        /// </summary>
        /// <param name="input">model input.</param>
        /// <returns><seealso cref=" ModelOutput"/></returns>
        public static ModelOutput Predict(ModelInput input)
        {
            var predEngine = PredictEngine.Value;
            return predEngine.Predict(input);
        }

        private static PredictionEngine<ModelInput, ModelOutput> CreatePredictEngine()
        {
            var mlContext = new MLContext();
            ITransformer mlModel = mlContext.Model.Load(MLNetModelPath, out var _);
            return mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);
        }
    }
}
