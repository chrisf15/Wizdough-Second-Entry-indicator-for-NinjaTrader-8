#region Using declarations
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Xml.Serialization;
using NinjaTrader.Cbi;
using NinjaTrader.Gui;
using NinjaTrader.Gui.Chart;
using NinjaTrader.Gui.SuperDom;
using NinjaTrader.Gui.Tools;
using NinjaTrader.Data;
using NinjaTrader.NinjaScript;
using NinjaTrader.Core.FloatingPoint;

#endregion



#region NinjaScript generated code. Neither change nor remove.

namespace NinjaTrader.NinjaScript.Indicators
{
	public partial class Indicator : NinjaTrader.Gui.NinjaScript.IndicatorRenderBase
	{
		
		private Wizdough.WiSE[] cacheWiSE;

		
		public Wizdough.WiSE WiSE(bool showSymbols, bool isResetDoubleTop, bool useEngulfing, int profitTarget, bool hideLong, bool hideShort, int maxHLCount, int maxEntryCount, bool hideIB, bool hide01, bool applyHLFilter, bool applyFailedFilter, double cHCLRatio, int hideRisk, bool hideByColor, double maxWickSize, bool hideByMa, WiSESignalValue signalValue, WiSEAlertSignal alert1, WiSEAlertSignal alert2, WiSEAlertSignal alert3, WiSEAlertSignal alert4, WiSEAlertSignal alert5, WiSEAlertSignal alert6, WiSEAlertSignal alert7, WiSEAlertSignal alert8, WiSEAlertSignal alert9, WiSEAlertSignal alert10, WiSEAlertSignal alert11, WiSEAlertSignal alert12)
		{
			return WiSE(Input, showSymbols, isResetDoubleTop, useEngulfing, profitTarget, hideLong, hideShort, maxHLCount, maxEntryCount, hideIB, hide01, applyHLFilter, applyFailedFilter, cHCLRatio, hideRisk, hideByColor, maxWickSize, hideByMa, signalValue, alert1, alert2, alert3, alert4, alert5, alert6, alert7, alert8, alert9, alert10, alert11, alert12);
		}


		
		public Wizdough.WiSE WiSE(ISeries<double> input, bool showSymbols, bool isResetDoubleTop, bool useEngulfing, int profitTarget, bool hideLong, bool hideShort, int maxHLCount, int maxEntryCount, bool hideIB, bool hide01, bool applyHLFilter, bool applyFailedFilter, double cHCLRatio, int hideRisk, bool hideByColor, double maxWickSize, bool hideByMa, WiSESignalValue signalValue, WiSEAlertSignal alert1, WiSEAlertSignal alert2, WiSEAlertSignal alert3, WiSEAlertSignal alert4, WiSEAlertSignal alert5, WiSEAlertSignal alert6, WiSEAlertSignal alert7, WiSEAlertSignal alert8, WiSEAlertSignal alert9, WiSEAlertSignal alert10, WiSEAlertSignal alert11, WiSEAlertSignal alert12)
		{
			if (cacheWiSE != null)
				for (int idx = 0; idx < cacheWiSE.Length; idx++)
					if (cacheWiSE[idx].ShowSymbols == showSymbols && cacheWiSE[idx].IsResetDoubleTop == isResetDoubleTop && cacheWiSE[idx].UseEngulfing == useEngulfing && cacheWiSE[idx].ProfitTarget == profitTarget && cacheWiSE[idx].HideLong == hideLong && cacheWiSE[idx].HideShort == hideShort && cacheWiSE[idx].MaxHLCount == maxHLCount && cacheWiSE[idx].MaxEntryCount == maxEntryCount && cacheWiSE[idx].HideIB == hideIB && cacheWiSE[idx].Hide01 == hide01 && cacheWiSE[idx].ApplyHLFilter == applyHLFilter && cacheWiSE[idx].ApplyFailedFilter == applyFailedFilter && cacheWiSE[idx].CHCLRatio == cHCLRatio && cacheWiSE[idx].HideRisk == hideRisk && cacheWiSE[idx].HideByColor == hideByColor && cacheWiSE[idx].MaxWickSize == maxWickSize && cacheWiSE[idx].HideByMa == hideByMa && cacheWiSE[idx].SignalValue == signalValue && cacheWiSE[idx].Alert1 == alert1 && cacheWiSE[idx].Alert2 == alert2 && cacheWiSE[idx].Alert3 == alert3 && cacheWiSE[idx].Alert4 == alert4 && cacheWiSE[idx].Alert5 == alert5 && cacheWiSE[idx].Alert6 == alert6 && cacheWiSE[idx].Alert7 == alert7 && cacheWiSE[idx].Alert8 == alert8 && cacheWiSE[idx].Alert9 == alert9 && cacheWiSE[idx].Alert10 == alert10 && cacheWiSE[idx].Alert11 == alert11 && cacheWiSE[idx].Alert12 == alert12 && cacheWiSE[idx].EqualsInput(input))
						return cacheWiSE[idx];
			return CacheIndicator<Wizdough.WiSE>(new Wizdough.WiSE(){ ShowSymbols = showSymbols, IsResetDoubleTop = isResetDoubleTop, UseEngulfing = useEngulfing, ProfitTarget = profitTarget, HideLong = hideLong, HideShort = hideShort, MaxHLCount = maxHLCount, MaxEntryCount = maxEntryCount, HideIB = hideIB, Hide01 = hide01, ApplyHLFilter = applyHLFilter, ApplyFailedFilter = applyFailedFilter, CHCLRatio = cHCLRatio, HideRisk = hideRisk, HideByColor = hideByColor, MaxWickSize = maxWickSize, HideByMa = hideByMa, SignalValue = signalValue, Alert1 = alert1, Alert2 = alert2, Alert3 = alert3, Alert4 = alert4, Alert5 = alert5, Alert6 = alert6, Alert7 = alert7, Alert8 = alert8, Alert9 = alert9, Alert10 = alert10, Alert11 = alert11, Alert12 = alert12 }, input, ref cacheWiSE);
		}

	}
}

namespace NinjaTrader.NinjaScript.MarketAnalyzerColumns
{
	public partial class MarketAnalyzerColumn : MarketAnalyzerColumnBase
	{
		
		public Indicators.Wizdough.WiSE WiSE(bool showSymbols, bool isResetDoubleTop, bool useEngulfing, int profitTarget, bool hideLong, bool hideShort, int maxHLCount, int maxEntryCount, bool hideIB, bool hide01, bool applyHLFilter, bool applyFailedFilter, double cHCLRatio, int hideRisk, bool hideByColor, double maxWickSize, bool hideByMa, WiSESignalValue signalValue, WiSEAlertSignal alert1, WiSEAlertSignal alert2, WiSEAlertSignal alert3, WiSEAlertSignal alert4, WiSEAlertSignal alert5, WiSEAlertSignal alert6, WiSEAlertSignal alert7, WiSEAlertSignal alert8, WiSEAlertSignal alert9, WiSEAlertSignal alert10, WiSEAlertSignal alert11, WiSEAlertSignal alert12)
		{
			return indicator.WiSE(Input, showSymbols, isResetDoubleTop, useEngulfing, profitTarget, hideLong, hideShort, maxHLCount, maxEntryCount, hideIB, hide01, applyHLFilter, applyFailedFilter, cHCLRatio, hideRisk, hideByColor, maxWickSize, hideByMa, signalValue, alert1, alert2, alert3, alert4, alert5, alert6, alert7, alert8, alert9, alert10, alert11, alert12);
		}


		
		public Indicators.Wizdough.WiSE WiSE(ISeries<double> input , bool showSymbols, bool isResetDoubleTop, bool useEngulfing, int profitTarget, bool hideLong, bool hideShort, int maxHLCount, int maxEntryCount, bool hideIB, bool hide01, bool applyHLFilter, bool applyFailedFilter, double cHCLRatio, int hideRisk, bool hideByColor, double maxWickSize, bool hideByMa, WiSESignalValue signalValue, WiSEAlertSignal alert1, WiSEAlertSignal alert2, WiSEAlertSignal alert3, WiSEAlertSignal alert4, WiSEAlertSignal alert5, WiSEAlertSignal alert6, WiSEAlertSignal alert7, WiSEAlertSignal alert8, WiSEAlertSignal alert9, WiSEAlertSignal alert10, WiSEAlertSignal alert11, WiSEAlertSignal alert12)
		{
			return indicator.WiSE(input, showSymbols, isResetDoubleTop, useEngulfing, profitTarget, hideLong, hideShort, maxHLCount, maxEntryCount, hideIB, hide01, applyHLFilter, applyFailedFilter, cHCLRatio, hideRisk, hideByColor, maxWickSize, hideByMa, signalValue, alert1, alert2, alert3, alert4, alert5, alert6, alert7, alert8, alert9, alert10, alert11, alert12);
		}
	
	}
}

namespace NinjaTrader.NinjaScript.Strategies
{
	public partial class Strategy : NinjaTrader.Gui.NinjaScript.StrategyRenderBase
	{
		
		public Indicators.Wizdough.WiSE WiSE(bool showSymbols, bool isResetDoubleTop, bool useEngulfing, int profitTarget, bool hideLong, bool hideShort, int maxHLCount, int maxEntryCount, bool hideIB, bool hide01, bool applyHLFilter, bool applyFailedFilter, double cHCLRatio, int hideRisk, bool hideByColor, double maxWickSize, bool hideByMa, WiSESignalValue signalValue, WiSEAlertSignal alert1, WiSEAlertSignal alert2, WiSEAlertSignal alert3, WiSEAlertSignal alert4, WiSEAlertSignal alert5, WiSEAlertSignal alert6, WiSEAlertSignal alert7, WiSEAlertSignal alert8, WiSEAlertSignal alert9, WiSEAlertSignal alert10, WiSEAlertSignal alert11, WiSEAlertSignal alert12)
		{
			return indicator.WiSE(Input, showSymbols, isResetDoubleTop, useEngulfing, profitTarget, hideLong, hideShort, maxHLCount, maxEntryCount, hideIB, hide01, applyHLFilter, applyFailedFilter, cHCLRatio, hideRisk, hideByColor, maxWickSize, hideByMa, signalValue, alert1, alert2, alert3, alert4, alert5, alert6, alert7, alert8, alert9, alert10, alert11, alert12);
		}


		
		public Indicators.Wizdough.WiSE WiSE(ISeries<double> input , bool showSymbols, bool isResetDoubleTop, bool useEngulfing, int profitTarget, bool hideLong, bool hideShort, int maxHLCount, int maxEntryCount, bool hideIB, bool hide01, bool applyHLFilter, bool applyFailedFilter, double cHCLRatio, int hideRisk, bool hideByColor, double maxWickSize, bool hideByMa, WiSESignalValue signalValue, WiSEAlertSignal alert1, WiSEAlertSignal alert2, WiSEAlertSignal alert3, WiSEAlertSignal alert4, WiSEAlertSignal alert5, WiSEAlertSignal alert6, WiSEAlertSignal alert7, WiSEAlertSignal alert8, WiSEAlertSignal alert9, WiSEAlertSignal alert10, WiSEAlertSignal alert11, WiSEAlertSignal alert12)
		{
			return indicator.WiSE(input, showSymbols, isResetDoubleTop, useEngulfing, profitTarget, hideLong, hideShort, maxHLCount, maxEntryCount, hideIB, hide01, applyHLFilter, applyFailedFilter, cHCLRatio, hideRisk, hideByColor, maxWickSize, hideByMa, signalValue, alert1, alert2, alert3, alert4, alert5, alert6, alert7, alert8, alert9, alert10, alert11, alert12);
		}

	}
}

#endregion
