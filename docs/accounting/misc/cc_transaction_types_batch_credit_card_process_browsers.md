---
title: CC Transaction Types
---

# CC Transaction Types


The values that can be displayed in the **CC 
 transaction** column of **Batch Payment 
 Process** browsers are detailed below:


|  | Processors + Selections on the Card Verification Dialog  Box |
| **CC TRANSACTION TYPE** | **IC Verify (MO)** | **IC Verify (Retail)** | Payflowpro | Saferpay |
| SALE | Sale | Sale | Sale | Sale |
| REFUND | Refund | Refund | Refund | Refund |
| AUTHORIZE | Pre-authorization + Authorize Only | Pre-authorization | Pre-authorization | Pre-authorization |
| BOOK | Pre-authorization + Book for Later Shipment |  |  |  |
| VOICE | Use prior authorization + Force Sale + manual entry of approval code | Use prior authorization + manual entry of approval code | Use prior authorization + Voice Authorization + manual entry of approval  code | Use prior authorization + Voice Authorization + manual entry of approval  code |
| CAPTURE | When "Authorize" type of transactions are processed (this  is the second stage of authorization) | When "Authorize" type of transactions are processed (this  is the second stage of authorization) | Use prior authorization + Delayed Capture + manual entry of PN  reference # | Use prior authorization + Capture + manual entry of approval code |
| SHIP | Use prior authorization + Ship (Prior Booking) + manual entry of approval  code |  |  |  |



All transactions processed on your **Everest 
 eStorefront** shop that use "WorldPay" are recorded as "Pre-paid"  transactions.


Sales orders imported with the credit card processing option set to  **No payment has been processed** are  recorded as "Sale or Authorize" transactions.


{:.see_also}
See also
: [Card  Verification Dialog Box]({{site.sp_chm}}/sales-docs/sales-orders/so-proc/pmts-refunds/cc-pmts/cc-verify-dlg/the_card_verification_dialog_box.html)
: [Columns  in the Batch Payment Process Browser]({{site.acc_baseurl}}/misc/columns_in_the_batch_credit_card_process_browser.html)
