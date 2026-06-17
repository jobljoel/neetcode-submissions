class DynamicArray {
    int* arr;
    int capacity;
    int length;
public:

    DynamicArray(int capacity): capacity(capacity), length(0) {
        arr = new int[capacity];
    }

    int get(int i) {
        return arr[i];
    }

    void set(int i, int n) {
        arr[i] = n;
    }

    void pushback(int n) {
        if (capacity == length) {
            resize();
        }
        arr[length] = n;
        length++;
    }

    int popback() {
        length--;
        return arr[length];
    }

    void resize() {
        capacity = capacity * 2;
        int* temp = new int[capacity];
        for (int i = 0; i < length; i++) {
            temp[i] = arr[i];
        }
        delete [] arr;
        arr = temp;
    }

    int getSize() {
        return length;
    }

    int getCapacity() {
        return capacity;
    }
};
