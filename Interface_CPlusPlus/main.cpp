#include "Animals.hpp"

int main() {

    Animals anim;
    anim.animalName("Dog");
    int animalAge = anim.age(5);
    std::cout << "Animals age is: " << animalAge << '\n';

    return 0;
}