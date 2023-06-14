using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordBank : MonoBehaviour
{
    private List<string> originalWords = new List<string>()
    {
        "dimension","interface","telescope","algorithm","synergy","platform","treasure","quintessence","emerald","celestial","hydraulic","rhapsody","vertigo","paragon","dulcimer","capricious","gratitude","blueprint","dandelion","obsidian","flamboyant","infinitesimal","turquoise","equilibrium","polarize","maverick","quasar","translucent","satellite","magnificent","carousel","backdrop","engineer","elephant","antelope","rhinoceros","paramount","kinematic","aesthetic","pineapple","cavalier","asterisk","quintet","juggernaut","mosaic","tambourine","kaleidoscope","juxtapose","silverware","terrarium","resonance","benevolent","fascinate","hologram","parabola","dichotomy","iridescent","gingerbread","cardiogram","enterprise","scintillate","saffron","vibrant","surreal","fledgling","harmonize","graphite","chromium","amplifier","tribulation","alabaster","cataclysm","limelight","escalator","apricot","xylophone","metropolis","espionage","wisteria","porcelain","aeronautic","avalanche","oblivion","barracuda","fireplace","longitude","espresso","balcony","radiator","orchestra","crocodile","chameleon","beetroot","impression","waterfall","rainforest","tourniquet","semaphore","revolver","camouflage","abundance","hieroglyph","obscurity","centurion","exponential","silverfish","vertebrate","equinox","corridor","holography","spectacle","ironclad","buttercup","snapdragon","geographer","passageway","innovate","underneath","rejuvenate","shipwreck","magnolia","landscape","freelance","consequence","nightshade","quicksilver","silhouette","retrograde","blossom","fragrance","threshold","butterfly","gentleman","hydroplane","teardrop","carousel","diplomat","carnation","millennium","persistence","transform","porcupine","copperhead","enchantment","relinquish","blackberry","geodesic","moonstone","revolution","asteroid","helicopter","barrister","constellation","archipelago","lighthouse","kaleidoscope","embroidery","imagination","solitaire","cavalryman","chrysanthemum","illuminate","starlight","boulevard","eucalyptus","brilliantine","hieroglyphics","astrolabe","formidable","cherubim","asparagus","brontosaurus","luminescent","pentagonal","saturation","vivacious","blacksmith","astounding","equilateral","thermometer","grapefruit","spectrometer","interpreter","continuum","labyrinth","thermostat","pomegranate","deuterium","wavelength","philanthropy","camellia","carnivorous","innovative","felicitous","anachronism","enlightened","incandescent","tangential","punctuality","concurrence","bittersweet","pantomime","quadrilateral","connoisseur","scaffolding","capillary","spheroidal","radiolarian","multiplicity","reverberate","penultimate","scintillation","abracadabra","triangulate","asymmetrical","kaleidoscopic","malachite","categorize","trigonometry","cosmopolitan","synchronization","metamorphosis","perseverance","adventurous","simultaneously","perspicacious","photovoltaic","surreptitiously","crystalline","photosynthesis","encompassing","unprecedented","demonstration","unobtainable","irreversible","transcendent","contemplative","approximate","equilibrant","opalescent","imperceptible","transformation","unforgettable","inquisitive","reminiscent","reconciliation","trapezoidal","conservation","mesmerizing","astronomical","cylindrical","sensational","incomparable","unbelievable","unconditional","extraordinary","undistinguishable","polychromatic","chrysanthemum","crystallize","breathtaking","xylophonist","conglomerate","periwinkle","butterfinger","antecedent","perspective","hummingbird","therapeutic","complimentary","accommodate","triceratops","electrolyte","heliotrope","aquamarine","indigofera","diplomatic","nomenclature","triathlon","tessellation","incongruity","plethora","anemometer","circumference","binoculars","palindrome","ambassador","quadruplets","pumpernickel","convoluted","stratosphere","mellifluous","hyphenated","calendula","elaborative","cinnamon","compartment","intriguing","equivalence","heliocentric","mandolin","squashbuckler","commensurate","ornamentation","velociraptor","paraphernalia","correspondence","mandrake","calibrate","procrastinate","saxophone","stalagmite","troubadour","barbecue","silversmith","propaganda","manipulate","silkworm","circuitous","annihilation","conservatory","chamberlain","buttercream","underground","compensate","fluorescent","enumeration","pontificate","monochromatic","incorporate","cliffhanger","ambrosia","counterpoint","polarization","accordion","basketball","symmetrical","predator","epitome","counterfeit","silhouette","conglomerate","underestimate","crimson","afterthought","persimmon","magnesium","undertow","bicentennial","blueberry","apocalyptic","deciduous","perseverance","cartographer","symbiosis","formulation","calibration","pathfinder","revolution","procrastinate","hexagonal","metropolitan","kilogram","extrapolate","helix","farsighted","gossamer","evaporate","parallax","anecdote","laboratory","observatory","brilliant","telegraph","decaffeinate","capricorn","parachute","chrysanthemum","effervescence","vagabond","geranium","gladiolus","galaxy","squirrel","strawberry","archaeology","firefly","cappuccino","woodpecker","rhinestone","promenade","baritone","carnelian","catamaran","thermodynamic","jackalope","carpenter","equation","philosophy","watermelon","phenomenon","evangelist","chocolate","handkerchief","buccaneer","buttercream","rejuvenate","landscape","declaration","penumbra","luminary","mistletoe","renaissance","saxophone","zucchini"
    };

    private List<string> workingWords = new List<string>();
    private string lastWord = string.Empty;

    private void Awake()
    {
        workingWords.AddRange(originalWords);
        ConvertToLower(workingWords);
        Shuffle(workingWords);
    }

    private void Shuffle(List<string> list)
    {
        for(int i = 0; i < list.Count; i++)
        {
            int random = Random.Range(i, list.Count);
            string temporary = list[i];

            list[i] = list[random];
            list[random] = temporary;
        }
    }

    private void ConvertToLower(List<string> list)
    {
        for(int i = 0; i < list.Count; i++)
        {
            list[i] = list[i].ToLower();
        }
    }

    public string GetWord()
    {
        string newWord = string.Empty;

        do
        {
            newWord = workingWords[0];
            workingWords.RemoveAt(0);
            workingWords.Add(newWord);
        } while (newWord == lastWord);
        lastWord = newWord;

        return newWord;
    }
}
