using Lists;

ArrayList list = new ArrayList(new int[4]{3,3,3,3});
int a;
a = list.DeleteFirstByValue(3);
ArrayList.Write(list);
list.DeleteFirstByValue(3);
ArrayList.Write(list);

