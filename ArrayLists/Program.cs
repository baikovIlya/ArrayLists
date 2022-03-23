using ArrayLists;

//ArrayList list = new ArrayList(new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 5 });
ArrayList list = new ArrayList(new int[5]{1,1,1,1,1});
ArrayList list2 = new ArrayList(new int[2]{2,2});
ArrayList.Write(list2);
list.AddAnotherListByIndex(0,list2);
ArrayList.Write(list);




