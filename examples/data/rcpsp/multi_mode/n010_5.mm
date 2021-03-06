************************************************************************
file with basedata            : me10_.bas
initial value random generator: 1092533753
************************************************************************
projects                      :  1
jobs (incl. supersource/sink ):  14
horizon                       :  103
RESOURCES
  - renewable                 :  2   R
  - nonrenewable              :  0   N
  - doubly constrained        :  0   D
************************************************************************
PROJECT INFORMATION:
pronr.  #jobs rel.date duedate tardcost  MPM-Time
    1     12      0       15        5       15
************************************************************************
PRECEDENCE RELATIONS:
jobnr.    #modes  #successors   successors
   1        1          3           2   3   4
   2        3          3           8   9  13
   3        3          3           5   6   7
   4        3          3           5   6   7
   5        3          2           9  10
   6        3          3           9  12  13
   7        3          1          10
   8        3          1          11
   9        3          1          11
  10        3          3          11  12  13
  11        3          1          14
  12        3          1          14
  13        3          1          14
  14        1          0        
************************************************************************
REQUESTS/DURATIONS:
jobnr. mode duration  R 1  R 2
------------------------------------------------------------------------
  1      1     0       0    0
  2      1     6       9    0
         2     7       0    7
         3     9       8    0
  3      1     3       0    3
         2     4       0    2
         3     7       9    0
  4      1     2       6    0
         2     3       0    7
         3     5       0    4
  5      1     5       0   10
         2     7       5    0
         3     9       4    0
  6      1     6       5    0
         2     6       0    3
         3    10       0    2
  7      1     1       7    0
         2     6       5    0
         3     8       0    9
  8      1     2       8    0
         2     3       7    0
         3     9       6    0
  9      1     1       4    0
         2     9       0    9
         3    10       2    0
 10      1     1       0    5
         2     8       5    0
         3     9       0    3
 11      1     5       8    0
         2     7       7    0
         3     8       5    0
 12      1     5       0    6
         2     5       3    0
         3     9       0    4
 13      1     2       0    6
         2     4       6    0
         3    10       5    0
 14      1     0       0    0
************************************************************************
RESOURCEAVAILABILITIES:
  R 1  R 2
   16   15
************************************************************************
