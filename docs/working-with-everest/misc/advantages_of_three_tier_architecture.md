---
title: Advantages of Three-tier Architecture
---

# Advantages of Three-tier Architecture


The Three-tier architecture is designed to maximize overall performance  of the application:

- **Autonomy**  - Application autonomy refers to an application's ability to govern its  critical resources. Critical resources are resources required by an application  to function reliably, as an independent entity. Windows DNA applications  never allow clients to have direct access to critical resources. Instead,  clients issue requests to special trusted components called executants  that perform the business operations, which the application was designed  to automate. By forcing clients to issue requests to executants that use  critical resources in trusted, well-defined ways, Windows DNA applications  remain in complete control of their critical resources. This ultimately  increases the application's overall stability.
- **Reliability**  - Reliability refers to an application's ability to provide accurate results.  An application is not reliable, if it returns inaccurate results. However,  ensuring accurate results in a multi-user environment is very difficult.  To ensure accurate results, the business operations are performed as part  of a transaction managed by a Microsoft Transaction Server (MTS). Transactions  ensure that state transformations are Atomic, Consistent, Isolated, and  Durable (ACID). Atomic operations are operations that take place entirely  or not at all. Consistent transformations preserve the internal integrity  of the resources involved. Isolated transformations appear to occur serially,  one after the other, creating the illusion that no other transformations  are being performed at the same time. Durable refers to the ability to  save the results of a state transformation, usually to a disk, such that  the results of a transformation can be recovered in the event of a system  failure.
- **Availability**  - Availability refers to the amount of time an application takes to provide  reliable service to client requests, and is important because an application  is useful only when it's available for servicing client requests. The  single points of failure are eliminated by implementing redundant hardware  and software systems, which includes using MSCS (Microsoft Cluster Server)  for redundancy solutions involving clustering. MSMQ's (Microsoft Message  Queuing) store and forward are used for guaranteed delivery and dynamic  routing features to enable increased network availability.
- **Scalability**  - Scalability  is the ability of an operating system to use multiple processors and to  vary the information content of a program by changing the amount of data  stored, transmitted, or displayed. Scalability  allows an application to support anywhere from ten users to tens of thousands  of users, by simply adding or subtracting the resources necessary, to  ‘scale’ the application. The resource acquisition time is minimized by  using MTS (Microsoft Transaction Server) to share resources among users  and to pool resources in short supply. Resource usage time is minimized  by avoiding network interaction and user input as part of the transaction,  and acquiring resources late and releasing them early.For increased throughput and truly dynamic load balancing, MSMQ  is used for emissary-to-executant  and executant-to-executant  communication.
- **Interoperability**  - Interoperability  refers to an application's ability to access applications, data or resources  on other platforms. Many enterprise environments support several different  kinds of hardware and software systems that must all work together for  the enterprise to be successful. This is why the three-tier architecture  is designed to be interoperable.

: Click [here]({{site.wwe_baseurl}}/introduction-to-everest/visual_representation_of_three_tier_architecture.html)  to view a visual representation of **Everest’s** Three-tier Architecture


{:.see_also}
See also
: [Three-tier  Architecture]({{site.wwe_baseurl}}/introduction-to-everest/three_tier_architecture.html)
