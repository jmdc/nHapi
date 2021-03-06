using System;
using NHapi.Base;
using NHapi.Base.Parser;
using NHapi.Base.Model;
using NHapi.Model.V271.Datatype;
using NHapi.Base.Log;

namespace NHapi.Model.V271.Segment{

///<summary>
/// Represents an HL7 UB1 message segment. 
/// This segment has the following fields:<ol>
///<li>UB1-1: Set ID - UB1 (SI)</li>
///<li>UB1-2: Blood Deductible (NM)</li>
///<li>UB1-3: Blood Furnished-Pints (NM)</li>
///<li>UB1-4: Blood Replaced-Pints (NM)</li>
///<li>UB1-5: Blood Not Replaced-Pints (NM)</li>
///<li>UB1-6: Co-Insurance Days (NM)</li>
///<li>UB1-7: Condition Code (IS)</li>
///<li>UB1-8: Covered Days (NM)</li>
///<li>UB1-9: Non Covered Days (NM)</li>
///<li>UB1-10: Value Amount and Code (UVC)</li>
///<li>UB1-11: Number Of Grace Days (NM)</li>
///<li>UB1-12: Special Program Indicator (ST)</li>
///<li>UB1-13: PSRO/UR Approval Indicator (ST)</li>
///<li>UB1-14: PSRO/UR Approved Stay-Fm (DT)</li>
///<li>UB1-15: PSRO/UR Approved Stay-To (DT)</li>
///<li>UB1-16: Occurrence (OCD)</li>
///<li>UB1-17: Occurrence Span (ST)</li>
///<li>UB1-18: Occur Span Start Date (DT)</li>
///<li>UB1-19: Occur Span End Date (DT)</li>
///<li>UB1-20: UB-82 Locator 2 (ST)</li>
///<li>UB1-21: UB-82 Locator 9 (ST)</li>
///<li>UB1-22: UB-82 Locator 27 (ST)</li>
///<li>UB1-23: UB-82 Locator 45 (ST)</li>
///</ol>
/// The get...() methods return data from individual fields.  These methods 
/// do not throw exceptions and may therefore have to handle exceptions internally.  
/// If an exception is handled internally, it is logged and null is returned.  
/// This is not expected to happen - if it does happen this indicates not so much 
/// an exceptional circumstance as a bug in the code for this class.
///</summary>
[Serializable]
public class UB1 : AbstractSegment  {

  /**
   * Creates a UB1 () segment object that belongs to the given 
   * message.  
   */
	public UB1(IGroup parent, IModelClassFactory factory) : base(parent,factory) {
	IMessage message = Message;
    try {
       this.add(typeof(SI), false, 1, 0, new System.Object[]{message}, "Set ID - UB1");
       this.add(typeof(NM), false, 1, 0, new System.Object[]{message}, "Blood Deductible");
       this.add(typeof(NM), false, 1, 0, new System.Object[]{message}, "Blood Furnished-Pints");
       this.add(typeof(NM), false, 1, 0, new System.Object[]{message}, "Blood Replaced-Pints");
       this.add(typeof(NM), false, 1, 0, new System.Object[]{message}, "Blood Not Replaced-Pints");
       this.add(typeof(NM), false, 1, 0, new System.Object[]{message}, "Co-Insurance Days");
       this.add(typeof(IS), false, 5, 0, new System.Object[]{message, 0}, "Condition Code");
       this.add(typeof(NM), false, 1, 0, new System.Object[]{message}, "Covered Days");
       this.add(typeof(NM), false, 1, 0, new System.Object[]{message}, "Non Covered Days");
       this.add(typeof(UVC), false, 8, 0, new System.Object[]{message}, "Value Amount and Code");
       this.add(typeof(NM), false, 1, 0, new System.Object[]{message}, "Number Of Grace Days");
       this.add(typeof(ST), false, 1, 0, new System.Object[]{message}, "Special Program Indicator");
       this.add(typeof(ST), false, 1, 0, new System.Object[]{message}, "PSRO/UR Approval Indicator");
       this.add(typeof(DT), false, 1, 0, new System.Object[]{message}, "PSRO/UR Approved Stay-Fm");
       this.add(typeof(DT), false, 1, 0, new System.Object[]{message}, "PSRO/UR Approved Stay-To");
       this.add(typeof(OCD), false, 5, 0, new System.Object[]{message}, "Occurrence");
       this.add(typeof(ST), false, 1, 0, new System.Object[]{message}, "Occurrence Span");
       this.add(typeof(DT), false, 1, 0, new System.Object[]{message}, "Occur Span Start Date");
       this.add(typeof(DT), false, 1, 0, new System.Object[]{message}, "Occur Span End Date");
       this.add(typeof(ST), false, 1, 0, new System.Object[]{message}, "UB-82 Locator 2");
       this.add(typeof(ST), false, 1, 0, new System.Object[]{message}, "UB-82 Locator 9");
       this.add(typeof(ST), false, 1, 0, new System.Object[]{message}, "UB-82 Locator 27");
       this.add(typeof(ST), false, 1, 0, new System.Object[]{message}, "UB-82 Locator 45");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

	///<summary>
	/// Returns Set ID - UB1(UB1-1).
	///</summary>
	public SI SetIDUB1
	{
		get{
			SI ret = null;
			try
			{
			IType t = this.GetField(1, 0);
				ret = (SI)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Blood Deductible(UB1-2).
	///</summary>
	public NM BloodDeductible
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(2, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Blood Furnished-Pints(UB1-3).
	///</summary>
	public NM BloodFurnishedPints
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(3, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Blood Replaced-Pints(UB1-4).
	///</summary>
	public NM BloodReplacedPints
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(4, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Blood Not Replaced-Pints(UB1-5).
	///</summary>
	public NM BloodNotReplacedPints
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(5, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Co-Insurance Days(UB1-6).
	///</summary>
	public NM CoInsuranceDays
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(6, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns a single repetition of Condition Code(UB1-7).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public IS GetConditionCode(int rep)
	{
			IS ret = null;
			try
			{
			IType t = this.GetField(7, rep);
				ret = (IS)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Condition Code (UB1-7).
   ///</summary>
  public IS[] GetConditionCode() {
     IS[] ret = null;
    try {
        IType[] t = this.GetField(7);  
        ret = new IS[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (IS)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  ///<summary>
  /// Returns the total repetitions of Condition Code (UB1-7).
   ///</summary>
  public int ConditionCodeRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(7);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns Covered Days(UB1-8).
	///</summary>
	public NM CoveredDays
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(8, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Non Covered Days(UB1-9).
	///</summary>
	public NM NonCoveredDays
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(9, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns a single repetition of Value Amount and Code(UB1-10).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public UVC GetValueAmountCode(int rep)
	{
			UVC ret = null;
			try
			{
			IType t = this.GetField(10, rep);
				ret = (UVC)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Value Amount and Code (UB1-10).
   ///</summary>
  public UVC[] GetValueAmountCode() {
     UVC[] ret = null;
    try {
        IType[] t = this.GetField(10);  
        ret = new UVC[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (UVC)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  ///<summary>
  /// Returns the total repetitions of Value Amount and Code (UB1-10).
   ///</summary>
  public int ValueAmountCodeRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(10);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns Number Of Grace Days(UB1-11).
	///</summary>
	public NM NumberOfGraceDays
	{
		get{
			NM ret = null;
			try
			{
			IType t = this.GetField(11, 0);
				ret = (NM)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Special Program Indicator(UB1-12).
	///</summary>
	public ST SpecialProgramIndicator
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(12, 0);
				ret = (ST)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns PSRO/UR Approval Indicator(UB1-13).
	///</summary>
	public ST PSROURApprovalIndicator
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(13, 0);
				ret = (ST)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns PSRO/UR Approved Stay-Fm(UB1-14).
	///</summary>
	public DT PSROURApprovedStayFm
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(14, 0);
				ret = (DT)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns PSRO/UR Approved Stay-To(UB1-15).
	///</summary>
	public DT PSROURApprovedStayTo
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(15, 0);
				ret = (DT)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns a single repetition of Occurrence(UB1-16).
	/// throws HL7Exception if the repetition number is invalid.
	/// <param name="rep">The repetition number (this is a repeating field)</param>
	///</summary>
	public OCD GetOccurrence(int rep)
	{
			OCD ret = null;
			try
			{
			IType t = this.GetField(16, rep);
				ret = (OCD)t;
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
  }

  ///<summary>
  /// Returns all repetitions of Occurrence (UB1-16).
   ///</summary>
  public OCD[] GetOccurrence() {
     OCD[] ret = null;
    try {
        IType[] t = this.GetField(16);  
        ret = new OCD[t.Length];
        for (int i = 0; i < ret.Length; i++) {
            ret[i] = (OCD)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
    } catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
  }
 return ret;
}

  ///<summary>
  /// Returns the total repetitions of Occurrence (UB1-16).
   ///</summary>
  public int OccurrenceRepetitionsUsed
{
get{
    try {
	return GetTotalFieldRepetitionsUsed(16);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(this.GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new System.Exception("An unexpected error ocurred", he);
} catch (System.Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new System.Exception("An unexpected error ocurred", cce);
}
}
}
	///<summary>
	/// Returns Occurrence Span(UB1-17).
	///</summary>
	public ST OccurrenceSpan
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(17, 0);
				ret = (ST)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Occur Span Start Date(UB1-18).
	///</summary>
	public DT OccurSpanStartDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(18, 0);
				ret = (DT)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns Occur Span End Date(UB1-19).
	///</summary>
	public DT OccurSpanEndDate
	{
		get{
			DT ret = null;
			try
			{
			IType t = this.GetField(19, 0);
				ret = (DT)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns UB-82 Locator 2(UB1-20).
	///</summary>
	public ST UB82Locator2
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(20, 0);
				ret = (ST)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns UB-82 Locator 9(UB1-21).
	///</summary>
	public ST UB82Locator9
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(21, 0);
				ret = (ST)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns UB-82 Locator 27(UB1-22).
	///</summary>
	public ST UB82Locator27
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(22, 0);
				ret = (ST)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }

	///<summary>
	/// Returns UB-82 Locator 45(UB1-23).
	///</summary>
	public ST UB82Locator45
	{
		get{
			ST ret = null;
			try
			{
			IType t = this.GetField(23, 0);
				ret = (ST)t;
			}
			 catch (HL7Exception he) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
				throw new System.Exception("An unexpected error ocurred", he);
		} catch (System.Exception ex) {
			HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
				throw new System.Exception("An unexpected error ocurred", ex);
    }
			return ret;
	}
  }


}}