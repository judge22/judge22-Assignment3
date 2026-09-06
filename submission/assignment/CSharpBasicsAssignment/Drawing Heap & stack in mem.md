# Part E — Memory Diagram (Stack & Heap)

### Step 1: `Order o1 = new Order { OrderId = 1, CustomerName = "Ali" };`

STACK                                   HEAP
+--------------------+                 +-------------------------------+
| o1 : 0x00FF1234    |---------------> | Order Object (0x00FF1234)     |
+--------------------+                 | ----------------------------- |
| OrderId: 1                    |
| CustomerName: "Ali"           |
| IsPaid: false                 |
| (Other fields default values) |
+-------------------------------+


*Explanation:* An `Order` object is instantiated on the Heap at address `0x00FF1234`. The reference variable `o1` is created on the Stack and stores this address.

---

### Step 2: `Order o2 = o1;`


STACK                                   HEAP
+--------------------+                 +-------------------------------+
| o1 : 0x00FF1234    |---------------> | Order Object (0x00FF1234)     |
+--------------------+                 | ----------------------------- |
| o2 : 0x00FF1234    |---------------> | OrderId: 1                    |
+--------------------+                 | CustomerName: "Ali"           |
| IsPaid: false                 |
| (Other fields default values) |
+-------------------------------+


*Explanation:* A new variable `o2` is created on the Stack. Assigning `o1` to `o2` copies the memory address (`0x00FF1234`), meaning both `o1` and `o2` now point to the exact same `Order` instance on the Heap.

---

### Step 3: `o2.IsPaid = true;`



STACK                                   HEAP
+--------------------+                 +-------------------------------+
| o1 : 0x00FF1234    |---------------> | Order Object (0x00FF1234)     |
+--------------------+                 | ----------------------------- |
| o2 : 0x00FF1234    |---------------> | OrderId: 1                    |
+--------------------+                 | CustomerName: "Ali"           |
| IsPaid: true  <-- UPDATED!    |
| (Other fields default values) |
+-------------------------------+



*Explanation:* Modifying `IsPaid` via `o2` mutates the single shared object on the Heap. Since `o1` references the same memory address, reading `o1.IsPaid` will also reflect this change as `true`.

---

## What would be different with structs?

If `Order` were defined as a `struct` instead of a `class`:
1. Both `o1` and `o2` would reside directly on the **Stack** containing their full field values.
2. Nothing would be allocated on the **Heap**.
3. Step 2 (`o2 = o1`) would perform a value copy, creating an independent second `Point`/`Order` struct on the Stack.
4. Step 3 (`o2.IsPaid = true`) would update only `o2`'s local fields on the Stack, leaving `o1` completely unaffected.



