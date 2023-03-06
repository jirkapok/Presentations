export enum Continents {
    Europe = 10,
    Asia = 20,
    America = 30,
    Africa = Math.random() // this was not possible in previous versions
}

// since TS2 union type, unable to compile in earlier versions, because of Africa
export type SelectedContinents = Continents.Europe | Continents.Africa;

export function selectContinent(source: Continents): SelectedContinents {
    return Continents.Africa;
}