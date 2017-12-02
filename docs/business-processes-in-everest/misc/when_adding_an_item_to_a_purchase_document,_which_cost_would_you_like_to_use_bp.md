---
title: When adding an item to a purchase document, which cost would you like to use?
---

# When adding an item to a purchase document, which cost would you like  to use?


Select the cost that should be used when you retrieve an item to a purchase  document.


The options are given in the following table.


| Option | Description |
| Vendor standard cost | Selects the vendor standard cost |
| Vendor last cost | Selects the vendor last cost |
| Item last cost | Selects the item last cost |
| Item average cost | Selects the item average cost |
| None | Dos not select any cost - shows zero in cost column |



| ![]({{site.bp_baseurl}}/img/note.gif) | - If **Vendor <br/> Standard cost** or **Vendor last cost**  is selected, as the cost to be used in the price column of purchase document  then:<br/>- If  associated vendor is selected in a purchase document:<br/>- The purchase  measure of the vendor will be shown with the standard cost/ last cost  and can be edited.  If  you update the purchase measure the price will be updated to zero and  you have to manually enter the price relevant to the selected measure.<br/>- In a purchase  order, the ordered quantity defaults to the EOQ or a single unit of the  purchase measure depending on the preference selected. If you set the  **Default quantity when an item is added <br/> to a purchase order/receipt** preference to EOQ but the EOQ is not  defined or equals zero, the ordered quantity defaults to one.<br/>- When you convert  a purchase order to a purchase receipt, the received quantity defaults  to the ordered quantity if the **Set the <br/> quantity received value to zero when converting a purchase/debit order <br/> to a purchase receipt/debit memo** preference (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Documents**  > **Miscellaneous** > **Others** > **Others <br/> 1** tab) is unchecked and the **Use <br/> default stock bin to receive items when creating a new purchase receipt/invoice**  option is checked (path: **Location**  profile > **Stock Transfer** tab  > **Miscellaneous** tab). If the  quantity received preference is checked or **Use <br/> default stock bin to receive items when creating a new purchase receipt/invoice**  option is unchecked, the received quantity defaults to zero.<br/>- In a purchase  receipt created directly, the received quantity defaults to the EOQ or  a single unit of the purchase measure depending on the preference selected  and when the **Use default stock bin to <br/> receive items when creating a new purchase receipt/invoice option**  is checked. Otherwise, the quantity defaults to zero. If you set the **Default quantity when an item is added to a <br/> purchase order/receipt** preference to EOQ but the EOQ is not defined  or equals zero, the received quantity defaults to one if the **Use <br/> default stock bin to receive items when creating a new purchase receipt/invoice**  option is selected; if not, the quantity defaults to zero.<br/><br/><br/><br/>{:.warn}<br/>You will be warned while saving the Purchase  Order or Receipt if the ordered/received quantity is less than the EOQ  unless you have not checked the **Default <br/> quantity when an item is added to a purchase order/receipt** preference.  Select **Yes** to retain the input  quantity or select **No** to manually  update the quantity before saving.<br/><br/>- If  the associated vendor is not selected in a purchase document:<br/>- The default  purchase measure of the item will appear and the cost will be zero because  there is no standard cost or vendor last cost set.<br/>- The EOQ will  not be considered.<br/>- In a purchase  order, the ordered quantity defaults to a single unit of the purchase  measure.<br/>- When you convert  a purchase order to a purchase receipt, the received quantity defaults  to the ordered quantity if the **Set the <br/> quantity received value to zero when converting a purchase/debit order <br/> to a purchase receipt/debit memo** preference (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Documents**  > **Miscellaneous** > **Others** > **Others <br/> 1** tab) is unchecked and the **Use <br/> default stock bin to receive items when creating a new purchase receipt/invoice**  option is checked (path: **Location**  profile > **Stock Transfer** tab  > **Miscellaneous** tab). If the  quantity received preference is checked or the **Use <br/> default stock bin to receive items when creating a new purchase receipt/invoice**  option is unchecked, the received quantity defaults to zero.<br/>- In a purchase  receipt created directly, the received quantity will default to a single  unit of the purchase measure if the **Use <br/> default stock bin to receive items when creating a new purchase receipt/invoice**  option is checked. Otherwise, it defaults to zero.<br/>- If **Item <br/> Last cost** or **Item Average cost**  is selected, as the cost to be used in the price column of the purchase  document:<br/><br/><br/>- If  associated vendor is selected in a purchase document:<br/><br/><br/>- The purchase  measure of the vendor and the item last cost or item average cost relevant  to the purchase measure of the vendor will appear. If the measure is edited,  the cost based on the measure selected will be picked up.<br/>- In a purchase  order, the ordered quantity defaults to the EOQ or a single unit of the  purchase measure depending on the preference selected. If you set the  **Default quantity when an item is added <br/> to a purchase order/receipt** preference to EOQ but the EOQ is not  defined or equals zero, the ordered quantity defaults to one.<br/>- When you convert  a purchase order to a purchase receipt, the received quantity defaults  to the ordered quantity if the **Set the <br/> quantity received value to zero when converting a purchase/debit order <br/> to a purchase receipt/debit memo** preference (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Documents**  > **Miscellaneous** > **Others** > **Others <br/> 1** tab) is unchecked and the **Use <br/> default stock bin to receive items when creating a new purchase receipt/invoice**  option is checked (path: **Location**  profile > **Stock Transfer** tab  > **Miscellaneous** tab). If the  quantity received preference is checked or the **Use <br/> default stock bin to receive items when creating a new purchase receipt/invoice**  option is unchecked, the received quantity defaults to zero.<br/>- In a purchase  receipt created directly, the received quantity defaults to the EOQ or  a single unit of the purchase measure depending on the preference selected  and when the **Use default stock bin to <br/> receive items when creating a new purchase receipt/invoice option**  is checked. Otherwise, the quantity defaults to zero. If you set the **Default quantity when an item is added to a <br/> purchase order/receipt** preference to EOQ but the EOQ is not defined  or equals zero, the received quantity defaults to one if the **Use <br/> default stock bin to receive items when creating a new purchase receipt/invoice**  option is selected; if not, the quantity defaults to zero<br/><br/><br/><br/>{:.warn}<br/>You will be warned while saving the Purchase  Order or Receipt if the ordered/received quantity is less than the EOQ  unless you have not checked the **Default <br/> quantity when an item is added to a purchase order/receipt** preference.  Select **Yes** to retain the input  quantity or select **No** to manually  update the quantity before saving.<br/><br/>- If  the associated vendor is not selected in a purchase document:<br/>- The default  purchase measure of the item and the item last cost or item average cost  relevant to the default purchase measure will appear. If the default purchase  measure is edited, the cost based on the measure selected will be picked  up.<br/>- The EOQ will  not be considered.<br/>- In a purchase  order, the ordered quantity defaults to a single unit of the purchase  measure.<br/>- When you convert  a purchase order to a purchase receipt, the received quantity defaults  to the ordered quantity if the **Set the <br/> quantity received value to zero when converting a purchase/debit order <br/> to a purchase receipt/debit memo** preference (path: **File**  > **Setup** > **Preferences**  > **Flow Control** > **Documents**  > **Miscellaneous** > **Others** > **Others <br/> 1** tab) is unchecked and the **Use <br/> default stock bin to receive items when creating a new purchase receipt/invoice**  option is checked (path: **Location**  profile > **Stock Transfer** tab  > **Miscellaneous** tab). If the  quantity received preference is checked or the **Use <br/> default stock bin to receive items when creating a new purchase receipt/invoice**  option is unchecked, the received quantity defaults to zero.<br/>- In a purchase  receipt created directly, the received quantity will default to a single  unit of the purchase measure if the **Use <br/> default stock bin to receive items when creating a new purchase receipt/invoice**  option is selected. Otherwise, it defaults to zero. |



{:.see_also}
See also
: [Prompts  - Purchase Document - Purchase Document 1]({{site.bp_baseurl}}/flow-ctrl/ctrl/doc-frm/prompts/purchase-prompts/prompts_purchase_document_purchase_document_1_bp.html)