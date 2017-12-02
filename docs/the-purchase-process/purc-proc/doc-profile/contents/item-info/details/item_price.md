---
title: Item Cost
---

# Item Cost


The **Item** **Cost**  column displays the cost at which the item is bought from the vendor.  By default, for a new company **Vendor 
 Standard cost** appears. If you have migrated from **Everest**  3.0 to **Everest** 3.0.1, **Item 
 Last cost** appears in this column. Change the item cost, if necessary.  You can also change the cost i.e. **Vendor 
 Standard cost**, **Vendor Last cost**,  **Item Last cost**, or **Item 
 Average cost** that should be used in this column. You can change  it in the [Documents  preferences]({{site.bp_chm}}/flow-ctrl/ctrl/opt/prompts-tab/prompts_purchase_document_tab_step_by_step_business_process_in_everest.html) (path: **File** >  **Setup** > **Preferences**  > **Flow Control** > **Documents**).  Enter the item cost in the cost decimal accuracy of the item.


{:.note}
If you want to change the default unit of  measure, the cost decimal accuracy, or the quantity decimal accuracy,  you need additional security rights.


![]({{site.pp_baseurl}}/img/lens.gif) [Factor  Cost]({{site.mi_chm}}/item-profile-details/item-costing/factored_cost_item_costing.html)


{:.note}
The cost of the item is the cost at which  an inventoried item is valued and a non-inventoried item is expensed.


{:.example}
If the vendor quotes a cost of $10 and a non-recoverable  tax of $1 is payable on the item, the cost entered is $11. If the tax  on the item is recoverable against sales tax collected from customers,  the cost of the item is $10.


Processed Documents


If a quote is converted to an order, or an order to a receipt or invoice,  the quoted or ordered cost is displayed. The cost can be changed on a  quote or an order at any time, but not on a saved purchase receipt or  invoice.


![]({{site.pp_baseurl}}/img/lens.gif) [Items  Costing]({{site.mi_chm}}/item-profile-details/item-costing/item_costing.html)


Foreign Currency Documents


All costs are displayed in the currency defined for the selected vendor  in the **Currency Code** field (path:  **Purchasing** > **Vendors**  > **Options &gt; Edit &gt; In New Window** > **Multicurrency** tab).


If the vendor's currency is different from the base currency, use the  **View in Document Currency** option  (path: **Purchase Document** profile  > **Options** > **View 
 in Document Currency**) to view in the cost in the base currency.


![]({{site.pp_baseurl}}/img/lens.gif) [Foreign Currency  Documents]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/tabs/details/for-cur-info/foreign_currency_document.html) ****


Select the **View in Document Currency**  option again to view the cost in the vendor’s currency.


{:.see_also}
See also
: [Item Information]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/item-info/item_information_pp.html)
: [Tax Code/Tax Amount]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/item-info/tax-details/tax_code_purchases.html)
