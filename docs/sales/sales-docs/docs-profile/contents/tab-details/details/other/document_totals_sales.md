---
title: Document Totals
---

# Document Totals


The following totals are summed, automatically updated and displayed  in all sales documents:


| Field | Description |
| Taxable | Displays the total value of items that are subject to  tax. The line items that are assigned tax codes are liable to be taxed.  The taxable amount includes the total amount of all such line items. The  amount is displayed after deducting the discount amount. |
| Tax | The total amount of sales tax chargeable on the line  items is displayed. Click on the ![]({{site.sp_baseurl}}/img/sales_tax_button.gif) button beside this field  to view the **Tax <br/> Breakdown** window that displays the detailed breakup of tax  charged.<br/><br/><br/>On a manual sales invoice this is the total of the Sales  Tax line entries either added manually by the user or inserted automatically  by the system. The Tax Breakdown is not available on a manual sales invoice. |
| Exempt | The total amount (after discount) of line items that  is taxable, is displayed here. |
| Payment Discount | Displays the amount of payment discount applied to the  document. This discount is calculated and applied based on the payment  terms selected for the document. This field is displayed only on a sales  invoice. |
| Total | The total amount of line items after tax and discount  is displayed. The Total is the sum of the totals of Taxable, Tax and Exempt  amounts.<br/><br/><br/>On a manual sales invoice this total will match the  amount specified against the Accounts Receivable entry. |
| Paid | Displays the total amount paid on the document. Click  the ![]({{site.sp_baseurl}}/img/sales_doc_alias_icon.gif) button beside this field to view the **Payment****History** window for payments made  against the document. |
| Balance | This field displays the balance amount (total amount  - paid amount) to be paid on the document, excluding payment discounts,  if any. |
| Deposit | Displays the amount of deposit paid on the selected  sales order. |



{:.note}
All the fields (taxable, tax, exempt, trade discount  and total) are display fields only (they are automatically generated).


Taxable, Tax, Exempt, and Total fields in Manual Sales  Journals


**Manual Sales Invoice**
: In the case of a manual journal created for a sales  invoice, the Taxable, Tax, Exempt, and Total fields are positive or negative  (shown in brackets) based on the following:


| Sales Invoice fields | Positive if: | Negative if: |
| Taxable | the total amount of taxable entries credited is higher  than total amount of taxable entries debited | the total amount of taxable entries debited is higher  than total amount of taxable entries credited |
| Tax | the total tax amount credited is higher than total tax  amount debited | the total tax amount debited is higher than total tax  amount credited |
| Exempt | the total Exempt amount credited is higher than total  Exempt amount debited | the total Exempt amount debited is higher than total  Exempt amount credited |
| Total | always positive because the Accounts Receivable for  a manual sales journal for a sales invoice will always be debited |  |



**Manual Credit Memo**
: In the case of a manual journal created for a credit  memo, the Taxable, Tax, Exempt, and Total fields are positive or negative  (shown in brackets) based on the following:


| Credit Memo fields | Positive if: | Negative if: |
| Taxable | the total amount of taxable entries debited is higher  than total amount of taxable entries credited | the total amount of taxable entries credited is higher  than total amount of taxable entries debited |
| Tax | the total tax amount debited is higher than total tax  amount credited | the total tax amount credited s higher than total tax  amount debited |
| Exempt | the total Exempt amount debited is higher than total  Exempt amount credited | the total Exempt amount credited is higher than total  Exempt amount debited |
| Total | always positive because the Accounts Receivable for  a manual sales journal for a credit memo will always be credited |  |

