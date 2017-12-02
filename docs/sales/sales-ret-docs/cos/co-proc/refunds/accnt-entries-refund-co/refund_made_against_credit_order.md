---
title: Accounting Entries - Refund Made Against Credit Order
---

# Accounting Entries - Refund Made Against Credit Order


The following accounting entries are created when a refund is made on  a credit order:


| Account | Entry Type | Path | Debit/<br/><br/><br/>Credit | Amount |
| Bank Account | Payment by cash/check/credit card/others | The account selected for **Accounts** in the **Payment Method** dialog  box (path: **File** > **Setup**  > **Accounting** > **Payment <br/> Methods** > **Options** >  **New** > **In <br/> New Window** > **General**  tab). | Credit | The amount of deposit paid at the payment rate. |
| Customer Deposit | Deposit on credit order | The account selected for **Customer <br/> Deposit** in the **Accounting**  dialog box (path: **File &gt; Setup &gt; <br/> Preferences &gt; Defaults &gt; Accounting &gt; Posting Group** tab). | Debit | The amount of deposit paid at the document rate. |
| Customer Deposit Account | Gain/Loss on deposit | The account selected for **Customer****Deposit** in the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Posting Group** tab) | Debit (if there is a gain)<br/><br/><br/>Credit (if there is a loss) | Difference between the amount at payment rate and document  rate. |



![]({{site.sp_baseurl}}/img/lens.gif) [Accounting  Dialog Box - Control Accounts](accounting.chm::/accounting_control_accounts.htm)


{:.see_also}
See also
: [Back  End Processes - Refund a Credit Order]({{site.sp_baseurl}}/sales-ret-docs/cos/co-proc/refunds/back-proc-refund-cc/back_end_processes_refund_a_credit_order.html)
