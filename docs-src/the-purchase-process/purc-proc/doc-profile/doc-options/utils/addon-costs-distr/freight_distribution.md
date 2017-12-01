---
title: Add-on Costs Distribution
---

# Add-on Costs Distribution


**Everest** allows you to distribute  additional expenses on the individual item through the **Add**-**on** **Costs****Distribution** utility (path: purchase/purchase  return document profile > **Options**  > **Utility** > **Add-on 
 Costs** **Distribution**).


![]({{site.pp_baseurl}}/img/lens.gif)[The Add-on  Costs Distribution Utility]({{site.pp_baseurl}}/purc-proc/doc-profile/doc-options/utils/addon-costs-distr/the_freight_distribution_utility.html)


In order to distribute add-on costs to items by weight or volume, you  must first specify a value for weight or volume for those items in the  Item profile (path: **Inventory**  > **Items** > **Options**  > **Edit** > **In 
 New Window** > **Purchases**  tab > **Freight** > **Item 
 Freight** dialog box).


The add-on costs distribution utility is not available for purchase  quotes and return documents. This option is however functional when you  enter negative quantities on a debit order or memo.


**Items Partially Received on an Order that has  Add-On Costs Distributed**
: If you distribute add-on costs on a purchase order  and receive the items partially on a purchase receipt or invoice, **Everest** prompts you if you want to reallocate  the add-on costs to just the items that are received. Click **Yes**  to view the **Add-On 
 Costs Distribution** dialog box where you can change the add-on  costs if required. Click **No** to  continue basing the add-on cost on the ordered quantity.


**Add-on Costs when Processing Purchase Documents**
: When you process a single purchase order/receipt  or debit order to a purchase receipt/invoice or debit memo, all add-on  cost details in the top grid of the Add-on Costs Distribution dialog box  carry into the new document.
: However, if you add new line items to the document  the system will not automatically distribute the add-on costs to the new  line items. You must open the Add-on Costs Distribution dialog box and  click the Distribute button to include the new line items into the distribution.  Select the User Specified distribution method if you want to apply the  add-on costs only to certain line items.
: If you retrieve additional lines using the document’s  **Process** > **Unreceived 
 Orders**, **Process** > **Uninvoiced Orders**, or **Process**  > **Uninvoiced Orders/Receipts**  option (depending on the purchase document), any add-on costs for those  line items do not carry forward and you must open the Add-on Costs Distribution  dialog box to add them manually. Select the User Specified distribution  method if you want to apply the add-on costs only to certain line items.  If you do not open the Add-on Costs Distribution dialog box, when you  save the document the system asks if you want to distribute the add-on  costs. You have the following options:

- **Yes**  to open the distribution screen and manually distribute the add-on costs.
- **No**  to save the document without adjusting the add-on costs (which leaves  incorrect data).
- **Cancel**  to return to the document without saving it.



**Add-on Costs when Converting Multiple Purchase  Orders/Receipts and Debit Orders**
: When you convert multiple purchase orders/receipts  or debit orders into a single purchase receipt/invoice or debit memo,  the system indicates that the add-on costs do not carry into the receipt/invoice.  This prevents accounting inaccuracies and other problems which would result  from combining the add-on costs of documents using  FOB  Origin with those using FOB Destination.
: In such case, The Add-on Costs Distribution dialog  box only displays the add-on cost elements set in the Add-on Costs profile  to appear automatically. You must manually enter the add-on cost details  of the new purchase document if you continue with the conversion. You  may close the new document without saving if you do not want to continue  the conversion.
