import { Continents, selectContinent, SelectedContinents } from "./enums";


describe("Enums", () => {
    it("Enum is a number constant", () => {
        expect(Continents.Europe).toEqual(10);
    });

    it("Enum is type union", () => {
        // selectContinent(5);  // Error value not assignable to Continents
        let found =  selectContinent(Continents.Europe); // required enum value

        // found = Continents.Asia; // not possible
        expect(found).toEqual(Continents.Africa);
    });
});