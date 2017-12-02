---
title: Pointers for Creating .INI file in Everest
---

# Pointers for Creating .INI  file in Everest

- Check if the format  for your processor is different from the default format used by **Everest**.



![]({{site.sc_baseurl}}/img/lens.gif)  [Default  Format Used by Everest]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/ini-file-for-icverify/default_format_used_by_everest_ic_verify_ini_files.html)

- If the format is  different, create the .INI  file.
- Identify the request  file format by entering **[REQUEST Processor 
 code]** in the first line. The processor code is defined in **Everest** (path: **Processor**  profile > **Code** field).
- You can set up  different file formats for a processor if the .REQ  file format is different for each processing network or for different  business types in the same network.
- A blank line may  separate the Request file and Answer file formats, though this is not  mandatory.
- Identify answer  file formats by entering [ANSWER Processor code]. Use the code as defined  in **Everest**.
- If you use a parameter  other than those listed earlier in the .INI  file, it is left blank in the .REQ  file (since **Everest** cannot identify  it). BLANK is indicated by "" in the .REQ  file.
- Lines starting  with a semi-colon are treated as comment lines.
- Hardcoded  values - Data that must go "as is" into the .REQ  files has to be enclosed within Angled '<' '>' brackets. These are  then treated as 'HARDCODED'  data values. Some processors require that the .REQ  file contain data in addition to the parameters listed earlier.



| ![]({{site.sc_baseurl}}/img/lens.gif) | [Parameters in a Request File]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/ini-file-for-icverify/parameters_in_request_files.html)<br/><br/><br/>[Parameters in an Answer File]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/ini-file-for-icverify/parameters_in_answer_file.html) |


- If these fields  are optional, a blank space can be part of the format in the required  position. If they are mandatory, then a hard coded value has to be entered  and made a part of the format.



{:.example}
The format for a sale transaction could be:


"C1,"CLERK","ORDERNO","ACCOUNT","EXP","


AMOUNT","RER","ZIP","ADDRESS","TAX","CVV2"
: The parameter RER  is not a part of the defined parameter list.  You  must specify the format as:
: SALE = <C1>,CLERK,ORDERNO,  ACCOUNT, EXP,AMOUNT,  ,ZIP, ADDRESS, TAX, CVV2
: But if RER  is mandatory, you must enter a hard coded value as a part of the string  as given below:
: SALE = <C1>, CLERK, ORDERNO,  ACCOUNT, EXP,  AMOUNT,<Comment>, ZIP, ADDRESS, TAX, CVV2

- Concatenating information  - Use the '+' sign to concatenate two parameters.



{:.example}
The swipe information (if available) is normally  appended to the expiration date.  In  this case, the .INI  file would be built as EXP+SWIPEINFO


Concatenation allows you to place the information  side by side and does not perform any other operation. AMT  + TAX, for instance, does not perform an addition operation. You can concatenate  any number of parameters, even if they are hardcoded.


{:.example}
You enter CLERK +< <Cmn>>  + ORDERNO in  the .INI file.  This may generate the following response string:


'SUP<Cmn>SO-1001'


If a ‘+’ sign appears within an angled bracket  (< >), the hardcoded  data is ignored, and it appears as a blank in the .REQ  file.


{:.example}
<C1+> is interpreted as " "  in the .REQ  file.

- Spaces Between  Parameters - You can indicate a blank space by entering **Space**.  This parameter is required to add a blank space to any concatenated data  or hard coded strings.



{:.example}
If the processor requires that the clerk’s name and order number be  separated by a space in the .REQ  file, you must enter the format as:


<CLERK+SPACE+ORDERNO>

- Blank Parameters  - If the processor format requires blank/empty parameters, these must  be entered using <+>.



{:.see_also}
See also
: [Create  an ICVerify Configuration File]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/ini-file-for-icverify/create_an_icverify_configuration_file.html)
: [Configuration  File for ICVerify]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/ini-file-for-icverify/configuration_file_for_icverify.html)
: [Sample .INI  File]({{site.sc_baseurl}}/options/payment-information/credit-card-processing/ini-file-for-icverify/sample_.ini_file.html)
