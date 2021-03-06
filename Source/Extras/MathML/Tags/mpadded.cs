//--------------------------------------
//               PowerUI
//
//        For documentation or 
//    if you have any issues, visit
//        powerUI.kulestar.com
//
//    Copyright ? 2013 Kulestar Ltd
//          www.kulestar.com
//--------------------------------------

using Dom;

namespace MathML{
	
	/// <summary>
	/// The MathML mpadded tag.
	/// </summary>
	
	[Dom.TagName("mpadded")]
	public class MathPaddedElement:MathElement{
		
		public override bool OnAttributeChange(string property){
			
			if(property=="depth"){
				
				return true;
				
			}else if(property=="lspace"){
				
				return true;
				
			}else if(property=="voffset"){
				
				return true;
				
			}else if(!base.OnAttributeChange(property)){
				return false;
			}
			
			return true;
		}
		
	}
	
}