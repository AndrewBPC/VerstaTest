

export function FormatDate(date){
    return new Date(date).toLocaleDateString('ru', { weekday:"long", year:"numeric", month:"short", day:"numeric"})
}