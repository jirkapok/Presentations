import { getNamesExactly, getNamesExactly5, getNamesOnArray5 } from "./generictypes";


describe("Generic types", () => {
    it("should used more precise type", () => {
         // TS4  returns string[]
        const namesA = getNamesExactly({ names: ["Alice", "Bob", "Eve"] });
        
        // TS4  returns readonly ["Alice", "Bob", "Eve"]
        const namesB = getNamesExactly({ names: ["Alice", "Bob", "Eve"] } as const);

        // TS5 returns readonly ["Alice", "Bob", "Eve"]
        const namesC = getNamesExactly5({ names: ["Alice", "Bob", "Eve"] });
        expect(namesA).toEqual(namesC);


    });

    it("has no effect on", () => {
        const arr = ["a", "b" ,"c"];

        // TS5 returns string[]
        const namesA = getNamesExactly5({ names: arr } as const);
        expect(namesA).toEqual(arr);

        // TS5 returns string[]
        const namesB = getNamesOnArray5(arr);
        expect(namesB).toEqual(arr);

        // TS5 returns readonly ["a", "b", "c"]
        const namesC = getNamesOnArray5(["a", "b" ,"c"]);
        expect(namesC).toEqual(["a", "b" ,"c"]);
    });
});