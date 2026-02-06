#include "IAnimal.hpp"
class Animals : public IAnimals
{
    public: 
    int age(int x) override;
    void animalName(const std::string& name) override;
};