---
title: Posting Groups for respective accounts
---

# Posting Groups for Respective Accounts


In manual journals, the accounts used for accounting entries depend  on the selection of the vendor or customer in the respective journal.  The table below also details the Posting Groups for the accounts.


| **Journal** | **Account** | **Selection** | **Posting Group** |
| Purchase Journals | A/P Control Account | Vendor | Vendor Posting Group |
| Payment Journals | A/P Control Account | Vendor | A/P Control Account defined in the corresponding purchase document or  journal. |
|  | Vendor Advances account |  | Vendor Posting Group for the selected vendor for the first deposit. |
|  | Miscellaneous Payments account |  | Expense account defined in the Vendor profile. In case this field is  blank, the expense account specified for the Vendor Posting Group is used. |
| Sales Journals | A/R Control Account | Customer | Customer Posting Group |
| Receipts Journals | A/R Control Account | Customer | A/R Control Account defined in the corresponding sales document or journal. |
|  | Customer Advances account |  | Customer Posting Group for the selected customer for the first deposit.<br/><br/><br/>The same account is used for subsequent deposits or when the deposit  is applied to subsequent receipts. |
|  | Miscellaneous Receipts account |  | Select any account in this field. |

