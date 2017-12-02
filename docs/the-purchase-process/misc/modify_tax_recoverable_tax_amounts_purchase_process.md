---
title: Modify Tax/Recoverable Tax Amounts
---

# Modify Tax/Recoverable Tax Amounts


You can modify the **Tax Amount**  and the **Recoverable Tax** amounts  only for tax codes associated with single tax components.


![]({{site.pp_baseurl}}/img/steps.gif)To modify the tax amount column, do the following:

- Place your  cursor in the [**Tax 
 Amount** column]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/item-info/tax-details/tax_amount.html) and click **Enter**.
- Enter a tax  amount.



{:.note}
: You can manually change the tax amounts for tax  codes that have only one tax component. You can change tax codes and tax  amounts only on documents that are not posted.


If you modify the **Tax Amount**,  the **Recoverable Tax** amount is  automatically calculated (as the recoverable percentage on the new tax  amount).


If the **Recoverable Tax** amount  is subsequently modified manually, the non-recoverable amount is calculated  as the difference between the tax amount and recoverable tax amount.


{:.example}
A purchase order contains item A worth $100  with a tax rate of 10 % and a recoverable tax rate of 60 %. Accordingly,  the tax for item A will be $10, while the recoverable tax will be 60 %  of $10, that is $6.


If you increase the tax amount to $15, the  recoverable tax amount automatically changes to $9 (60 % of $15). If you  then increase the recoverable tax amount to $12, the tax amount will NOT  change to $20. Instead, the non-recoverable tax amount will be the difference  between tax amount and the recoverable tax amount, i.e. $3.


These modifications are allowed only on unposted documents. The tax  amount or recoverable tax amounts cannot be negative.


{:.note}
: The recoverable tax amount entered manually in one  view i.e., **Invoiced** view will  be calculated proportionately and displayed in other view i.e., **Received** view. This applies only for  purchase invoices.


{:.see_also}
See also
: [Recoverable  Tax]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/item-info/tax-details/recoverable_tax_item_details_grid_purchase_content.html)
: [Tax]({{site.pp_baseurl}}/purc-proc/doc-profile/contents/item-info/tax-details/tax_item_details_grid_purchase_content.html)
