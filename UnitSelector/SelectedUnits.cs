using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using UnitsNet;
using UnitsNet.Units;

namespace UnitsSelector
{
    public class SelectedUnits
    {
        //public DataTable DataTable;
        public BindingList<BindingList<UnitListItem>> UnitsList { get; set; }
        public BindingList<QuantityType> QuantityTypes { get; set; }
        public BindingList<int> SelectedUnitIndex { get; set; }

        public SelectedUnits()
        {


            QuantityTypes = getQuantities();
            UnitsList = new BindingList<BindingList<UnitListItem>>();
            SelectedUnitIndex = new BindingList<int>();
            GetUnitsForEachQuantity();
            setSelectedIndexInitialValues();
        }

  

        private void setSelectedIndexInitialValues()
        {
            for (int i = 0; i < QuantityTypes.Count; i++)
            {
                SelectedUnitIndex.Add(i);
            }
        }
        private void GetUnitsForEachQuantity()
        {
            foreach (var qt in QuantityTypes)
            {
                UnitsList.Add(getUnitsForType(qt));

            }
        }

        public BindingList<QuantityType> getQuantities()
        {
            return ToReadOnly(Quantity.Types);
        }

        private static BindingList<T> ToReadOnly<T>(IEnumerable<T> items)
        {
            return new BindingList<T>(new List<T>(items));
        }

        private BindingList<UnitListItem> getUnitsForType(QuantityType quantityType)
        {
            BindingList<UnitListItem> _units = new BindingList<UnitListItem>();

            QuantityInfo quantityInfo = Quantity.GetInfo(quantityType);

            foreach (Enum unitValue in quantityInfo.Units)
            {
                _units.Add(new UnitListItem(unitValue));
            }
            return _units;
        }
    }
}