---
title: List Semaphore Locks
---

# List Semaphore Locks


Semaphore locks are used to lock documents, journals, batch updates  (reports), etc., so that two users cannot access the same profile/dialog  box/window for modification.


**Everest** does not allow two users  to use the same document for modification at the same time. The user who  opened the document first will have rights to work on it. (The system  locks the document for the first user).


{:.example}
If you have opened a sales document for modification,  the system locks the document for you. Another user who wants to modify  the same sales document will not be given access by the system for modification.  **Everest** displays a message to  the second user saying the document is locked and can only be viewed.


{:.steps}
To view semaphore locks, do the following<font style="color: #000000;" color="#000000">:</font>

- From the **Logged-in Users** browser, highlight the  user and select **Options &gt; List Semaphore 
 Locks**. You will see the [**Semaphore 
 Locks** browser]({{site.wwe_baseurl}}/misc/semaphore_locks_browser.html).



{:.note}
You can view locks for a selected user or  for all users.


{:.see_also}
See also
: [The **Logged-in Users** Browser]({{site.wwe_baseurl}}/misc/the_logged_in_users_browser.html)
: [Active and  Inactive Users]({{site.wwe_baseurl}}/misc/active_and_inactive_users.html)
