---
title: Accounting Entries - Applying a Debit Memo to a Purchase Order
---

# Accounting Entries - Applying a Debit Memo to a Purchase Order


The accounting entry created when a debit memo is applied to a purchase  order is detailed below:


| **Entry type** | **Document #** | **Account** | **Path** | **Debit/**<br/><br/><br/>**Credit** | **Amount** |
| Payment by check/others/credit card/cash | Nil | Bank Account | The account defined in the **Account**  field of the **Payment Method** profile  (path: **File** > **Setup**  > **Accounting** > **Payment****Methods** > **Options**  > **Edit** > **In <br/> New Window**). | Credit | Nil |
| Deposit on Purchase Order | Purchase order number | Vendor Deposits Account | The account specified in the **Vendor <br/> deposit** field of the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab). | Debit | Amount of original debit memo in document currency applied to the exchange  rate specified in the Exchange Info tab of the Payment dialog box at the  time you apply the DM to the PO. |
| Apply/refund debit memo | Debit memo number | Accounts Payable Account | The account specified in the **Accounts****payable** field of the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab).<br/><br/><br/>![]({{site.pp_baseurl}}/img/lens.gif) [Accounting  dialog box - Posting Group tab]({{site.acc_chm}}/accounting-flow-control-and-defaults/accounting-defaults/accounting_dialog_box_-_posting_groups.html) | Credit | Amount of original debit memo in document currency applied to the exchange  rate used when the debit memo was created |
| Gain/Loss on Forex Transaction |  | G/L account for gain/loss on foreign exchange transactions | **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**.  Select the **Multi-Currency** tab. | Gain is posted here | Loss is posted here |



{:.see_also}
See also
: [Default  Accounts for Purchase Transactions]({{site.pp_baseurl}}/misc/default_accounts_for_purchase_transactions.html)
