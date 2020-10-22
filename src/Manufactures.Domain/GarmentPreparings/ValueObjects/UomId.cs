﻿using Moonlay.Domain;
using Newtonsoft.Json;

namespace Manufactures.Domain.GarmentPreparings.ValueObjects
{
    [JsonConverter(typeof(SingleValueObjectConverter))]
    public class UomId : SingleValueObject<int>
    {
        public UomId(int value) : base(value)
        {
        }
    }
}
