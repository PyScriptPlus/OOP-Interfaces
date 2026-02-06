#ifndef ANIMAL_HPP
#define ANIMAL_HPP

#include <iostream>
#include <string>

class IAnimals{
    public:

    virtual int age(int x) = 0;
    virtual void animalName(const std::string& name) = 0;
    virtual ~IAnimals() {};
};


#endif