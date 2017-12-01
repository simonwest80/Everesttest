---
title: The Cash Register Profile - Point of Sale Tab
---

# The Cash Register Profile - Point of Sale Tab


This tab enables you to prompt for printer selection,  specify a standard message that should be printed on the POS receipt,  default document aliases, journal group and customer for the cash register.


**Default Document Alias for Invoices**
: Specify a default document alias for all sales made  through the specific cash register in a Point of Sale transaction. Document  aliases are defined in the **Document Alias**  profile (path: **File** > **Setup** > **Miscellaneous**  > **Document** **Aliases**  > **Options** > **Edit**  > **In New Window**).


{:.example}
You can have separate cash registers for the sale of  different lines of products like perfumes, books etc. You can then specify  a document alias called ‘POS Invoice - Books’ for the particular cash  register.
: **** [Document  Aliases]({{site.bp_chm}}/doc-aliases/document_aliases_businesss_process_in_everest_content.html)


**Default Document Alias for Returns**
: Specify a default document alias for all sales returns  made through the specific cash register in a Point of Sale transaction.  Document aliases are defined in the **Document 
 Alias** profile (path: **File**  > **Setup** > **Miscellaneous**  > **Document** **Aliases**  > **Options** > **Edit** > **In New Window**).


{:.example}
You can have separate cash registers for the return  of different lines of products like perfumes, books, etc. You can then  specify a document alias called ‘POS Credit Memo - Cosmetics’ for the  particular cash register.
: ![]({{site.pos_baseurl}}/img/lens.gif) [Document  Aliases]({{site.bp_chm}}/doc-aliases/document_aliases_businesss_process_in_everest_content.html)


**Journal Group**
: Specify the journal group under which all the transactions  for this cash register are grouped. This field is an alphanumeric field.


**Default POS customer**
: If it is required to record the sale transaction  in the same currency as the payment currency, you can setup different  POS counters for each currency that you accept. In such cases, you can  have a default POS customer for each cash register. Specify the default  POS customer for this cash register from the drop-down list. The list  displays all customers created in **Everest**.  If you leave this field blank, the **Customers**  browser is displayed when you create a POS invoice.


Point of Sale Information


**Prompt user for printer selection**
: Select this check box if you want **Everest**  to prompt you to select a printer before printing a receipt.


**Message at the end of receipt**
: Enter a message to printed at the end of the receipt.  You can also attach tags in this field by selecting **Options 
 &gt; Tags** from the **Cash Register**  profile. These tags get translated into the actual data which can be printed  each time the receipt is printed using crystal reports.
: ![]({{site.pos_baseurl}}/img/lens.gif) [Printing  Point of Sale Receipts]({{site.pos_baseurl}}/pos-trans/create-pos-doc/pos-receipts/printing/printing_point-of-sale_receipts.html)


{:.see_also}
See also
: [The  Cash Register Profile]({{site.pos_baseurl}}/pos-setup/cash-registers/setup/profile/the_cash_register_profilepos_set_up.html)
: [Setting  up a Cash Register]({{site.pos_baseurl}}/pos-setup/cash-registers/setup/setting_up_a_cash_register_pos_set_up.html)
