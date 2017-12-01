---
title: Accounting Entries - Deposit on a Purchase Order
---

# Accounting Entries - Deposit on a Purchase Order


The accounting entry made when a new payment is made on a purchase order  is detailed below:


| **Entry type** | **Account** | **Path** | **Debit/**<br/><br/><br/>**Credit** | **Amount** |
| Payment by check/others/credit card/cash | Bank Account (the account defined for the Payment Method  selected) | The account defined in the **Account**  field of the **Payment Method** profile  (path: **File** > **Setup**  > **Accounting** > **Payment****Methods** > **Options**  > **Edit** > **In New Window** > **General**  tab). | Credit | Amount paid |
| Deposit on Purchase Order | Vendor Deposits Account | The account specified in the **Vendor <br/> deposit** field of the **Accounting**  dialog box (path: **File** > **Setup** > **Preferences**  > **Defaults** > **Accounting**  > **Control Accounts** tab).<br/><br/><br/>![]({{site.pp_baseurl}}/img/lens.gif) [Accounting  dialog box - Control Accounts tab](accounting.chm::/accounting_control_accounts.htm) | Debit | Amount paid |

