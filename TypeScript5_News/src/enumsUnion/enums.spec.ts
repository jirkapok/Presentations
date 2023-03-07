import { Continents, selectContinent, SelectedContinents } from "./enums";


describe("Enums", () => {
    it("Enum is a number constant", () => {
        expect(Continents.Europe).toEqual(10);
    });

    it("Enum is type union", () => {
        selectContinent(5);
        let found: SelectedContinents =  selectContinent(Continents.Europe); // required enum value

        found = Continents.Africa; // not possible
        console.log(found === 10);
        console.log(found);
        console.log(Continents["Africa"]);
        console.log(Continents[10]);

        expect(found).toEqual(Continents.Africa);
    });
});