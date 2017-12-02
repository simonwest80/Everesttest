---
title: Convert Multiple Purchase Orders into a Purchase Receipt
---

# Convert Multiple Purchase Orders into a Purchase Receipt


You can convert multiple purchase orders to a receipt from the Purchase  Orders browser by choosing orders in the browser and selecting the **Process** > **Receive**  option in the browser’s **Options**  menu.


| ![]({{site.pp_baseurl}}/img/note.gif) | - If you have  selected multiple purchase orders and convert into a purchase receipt,  the system validates the following information pertain to the vendor of  the first selected order:<br/>- FOB type<br/>- Accrued Purchase  Account<br/>- Received Status  of the document<br/><br/>: Only the purchase orders that fulfill the above  conditions are converted into a purchase receipt. Also, the system excludes  the Drop ships and linked documents associated to the vendor of the first  selected order. You will see the message with the information on the purchase  order numbers that are converted to a receipt.<br/><br/><br/>{:.example}<br/>Let us assume that you have selected seven  purchase orders and four of them pertain to the vendor of the first selected  order ‘BIRKEN PRODUCTS’. The system validates the FOB type, Accrued Purchase  Account, and Received Status of the document of the vendor of the first  selected order and converts only three orders into a receipt. This indicates  that the Drop ships and linked documents, and the orders pertain to other  vendors are excluded when you convert multiple purchase orders into a  purchase receipt.<br/><br/>- If none of the  selected purchase orders are converted to purchase receipts, then the  system displays a warning message, ‘The selected vendor does not have  any line items pending, or some orders may be drop ship or linked and  ignored.’ |



{:.see_also}
See also
: [Purchase  Orders Browser - Other Options]({{site.pp_baseurl}}/misc/other_options_po_browser_options.html)
