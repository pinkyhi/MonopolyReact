﻿namespace Monopoly.API.ViewModels
{
    using AutoMapper;
    using Monopoly.BL.Models;

    [AutoMap(typeof(GameSettingsModel))]
    public class GameSettingsViewModel
    {
        public int GameSettingsId { get; set; }

        public int StartMoney { get; set; }

        public int ImprisonmentDuration { get; set; }

        public int JailbreakPrice { get; set; }

        public int ImprisonmentTurnsCount { get; set; }

        public int HousesCount { get; set; }

        public int HotelsCount { get; set; }

        public int RightStartHitAward { get; set; }

        public int CasinoType { get; set; }

        public int? DoublesCountsForArrest { get; set; }

        public bool DoubleRepeatsTurn { get; set; }

        public bool AnytimeExchange { get; set; }

        public bool AnytimeBuilding { get; set; }

        public bool MovementFields { get; set; }

        public bool Auction { get; set; }

        public bool BuildingBalancing { get; set; }

        public bool FullCollateralValue { get; set; }

        public bool DoublePayOnUnbuildedMonopoly { get; set; }

        public bool DoubleBreaksJail { get; set; }
    }
}