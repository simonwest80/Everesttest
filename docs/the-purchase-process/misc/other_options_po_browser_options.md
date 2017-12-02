---
title: Purchase Orders Browser - Other Options
---

# Purchase Orders Browser - Other Options


**Search By Vendor**
: Select this option to view a list of all orders  created for the vendors of the selected documents.


{:.example}
If you highlight documents with "ABC"  and "EFG"  as vendors; and select **Search by Vendor 
 &gt; Purchase Orders**, the browser displays all purchase orders  created for these vendors.


**Process > Unreceived Orders**
: Use this option to convert multiple purchase orders  into a single purchase receipt. From the list of open purchase orders,  select the orders of interest then process them from the Options menu.  A new purchase receipt opens with the chosen orders included (excluding  drop ship line items). If you select purchase orders from multiple vendors,  the vendor of the first selected purchase order appears at the top of  the purchase receipt and the items display by vendor in the item details  grid.
: All of the orders must use the same Accrued Purchases  account. If your selection includes different accounts, the system gives  you an error message and incorporates into the purchase receipt only those  orders using the same Accrued Purchases account as the first purchase  order selected. (The Accrued Purchases Account column is available in  the field chooser of the browser.)
: All of the receipts must also use the same FOB type.  If they do not, the system prompts that only receipts with FOB type matching  the FOB type of the first selected record will get converted.
: When you convert multiple purchase orders into a  single purchase receipt, the system indicates that the add-on costs do  not carry into the receipt. You must manually enter the add-on cost details  into the **Add-on Costs Distribution**  dialog box of the new purchase receipt if you continue with the conversion.  The **Add-on Costs Distribution**  dialog box only displays the add-on cost elements set in the **Add-on 
 Costs** profile to appear automatically. You may close the new receipt  without saving if you do not want to continue the conversion.
: When you convert multiple orders into one purchase  receipt, information does not copy into the following tabs of the **Purchase Receipt** profile:

- History
- Multimedia
- Custom Fields
- Document Tasks
- Document Tracking



**Process > Uninvoiced Orders**
: Use this option to convert multiple purchase orders  into a single purchase invoice. From the list of open purchase orders,  select the orders of interest then process them from the Options menu.  A new purchase invoice opens with the chosen orders included that processes  only line items/orders that are fully received. If you select purchase  orders from multiple vendors, the vendor of the first selected purchase  order appears at the top of the purchase invoice and the items display  by vendor in the item details grid.


{:.note}
Lines items that are linked to sales documents  are included only if they have been fully received.
: All of the orders must use the same Accrued Purchases  account. If your selection includes different accounts, the system gives  you an error message and incorporates into the purchase invoice only those  orders using the same Accrued Purchases account as the first purchase  order selected. (The Accrued Purchases Account column is available in  the field chooser of the browser.)
: All of the receipts must also use the same FOB type.  If they do not, the system prompts that only receipts with FOB type matching  the FOB type of the first selected record will get converted.
: When you convert multiple purchase orders into a  single purchase invoice, the system indicates that the add-on costs do  not carry into the invoice. You must manually enter the add-on cost details  into the **Add-on Costs Distribution**  Screen.


{:.note}
- If you convert  a single order to a receipt from the browser, the add-on cost details  will be carried forward.
- If you convert  multiple orders to receipts from the browser, the add-on cost will not  be carried forward and then the system prompts that you have to manually  enter the add-on cost.
- If you retreive  the line items within a document, the add-on cost details will not be  carried forward irrespective of whether they have been retreived from  single or multiple documents.
: When you convert multiple orders into one purchase  invoice, information does not copy into the following tabs of the Purchase  Invoice profile:

- History
- Multimedia
- Custom Fields
- Document Tasks
- Document Tracking



**Fully Received and Invoiced/Open Purchase Orders**
: Use this toggle option to view purchase orders which  are either closed or still open. A closed purchase order is both fully  received and fully invoiced; an open purchase order has not been fully  received, has not been fully invoiced, or both.


**Include/Exclude Manual Documents**
: Select this toggle option to include/exclude manual  purchase documents from the browser.
: When you create a manual journal entry in a payment  journal with an entry type of 'miscellaneous deposits to a vendor', the  document number you enter is created as a "Manual" purchase  order. It is prefixed with "M".


![]({{site.pp_baseurl}}/img/lens.gif) [Manual  Purchase Orders]({{site.pp_baseurl}}/purc-proc/pos/create-po/manually-creating-purchase-orders/manual_purchase_orders.html)


{:.see_also}
See also
: [The Purchase  Order Browser Options]({{site.pp_baseurl}}/purc-proc/pos/purchase-order-browser/purchase_order_browser.html)
